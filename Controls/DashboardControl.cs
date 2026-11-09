using Hotel_Management.Models;
using Hotel_Management.Services;
using LiveChartsCore.SkiaSharpView;

namespace Hotel_Management;

public partial class DashboardControl : UserControl
{
    private readonly RoomService _roomService;
    private readonly CustomerService _customerService;
    private readonly ReservationService _reservationService;
    private List<RoomModel> _rooms = [];
    private List<CustomerModel> _customers = [];
    private List<ReservationModel> _reservations = [];

    public DashboardControl(
        RoomService roomService,
        CustomerService customerService,
        ReservationService reservationService)
    {
        InitializeComponent();

        _roomService = roomService;
        _customerService = customerService;
        _reservationService = reservationService;
        Load += DashboardControl_Load;
    }

    private void DashboardControl_Load(object? sender, EventArgs e)
    {
        try
        {
            _roomService.LoadRoom();
            _customerService.LoadCustomer();
            _reservationService.LoadReservation();

            _rooms = _roomService.GetRooms().ToList();
            _customers = _customerService.GetCustomers().ToList();
            _reservations = _reservationService.GetReservations().ToList();

            UpdateSummaryCards();
            UpdateTodayActivity();
            UpdateMaintenanceAlerts();
            UpdateCharts();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Unable to load dashboard data: {ex.Message}",
                "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void UpdateSummaryCards()
    {
        var today = DateTime.Today;
        var occupiedRooms = _rooms.Count(room => room.Status == RoomStatus.Occupied);
        var monthStart = new DateTime(today.Year, today.Month, 1);
        var monthEnd = monthStart.AddMonths(1);
        var monthlyRevenue = _reservations
            .Where(reservation => !IsCancelled(reservation.ReservationStatus))
            .Sum(reservation => GetRevenueInPeriod(reservation, monthStart, monthEnd));
        var todayCheckIns = _reservations.Count(reservation =>
            reservation.CheckInDate.Date == today && IsReserved(reservation.ReservationStatus));

        lbTotalRooms.Text = _rooms.Count.ToString();
        lbAvailableRooms.Text = _rooms.Count == 0
            ? "0%"
            : $"{occupiedRooms * 100d / _rooms.Count:0.#}%";
        lbOccupiedRooms.Text = monthlyRevenue.ToString("C0");
        lbReservedRooms.Text = todayCheckIns.ToString();
    }

    private void UpdateTodayActivity()
    {
        var today = DateTime.Today;
        var customersById = _customers.ToDictionary(customer => customer.CustomerId);
        var roomsById = _rooms.ToDictionary(room => room.RoomId);
        var activities = _reservations
            .Where(reservation =>
                reservation.CheckInDate.Date == today || reservation.CheckOutDate.Date == today)
            .Select(reservation => new
            {
                Event = reservation.CheckInDate.Date == today ? "Check-in" : "Check-out",
                Guest = customersById.TryGetValue(reservation.CustomerId, out var customer)
                    ? customer.CustomerName
                    : $"Customer #{reservation.CustomerId}",
                Room = roomsById.TryGetValue(reservation.RoomId, out var room)
                    ? room.RoomNumber.ToString()
                    : $"Room #{reservation.RoomId}",
                reservation.ReservationStatus
            })
            .OrderBy(activity => activity.Event == "Check-in" ? 0 : 1)
            .ThenBy(activity => activity.Guest)
            .ToList();

        dgvTodayCheckInOut.AutoGenerateColumns = true;
        dgvTodayCheckInOut.DataSource = activities;
        dgvTodayCheckInOut.ClearSelection();
        if (dgvTodayCheckInOut.Columns["Event"] is { } eventColumn)
            eventColumn.HeaderText = "Activity";
        if (dgvTodayCheckInOut.Columns["Guest"] is { } guestColumn)
            guestColumn.HeaderText = "Guest";
        if (dgvTodayCheckInOut.Columns["Room"] is { } roomColumn)
            roomColumn.HeaderText = "Room";
        if (dgvTodayCheckInOut.Columns["ReservationStatus"] is { } statusColumn)
            statusColumn.HeaderText = "Status";

        if (activities.Count == 0)
        {
            dgvTodayCheckInOut.DataSource = null;
            dgvTodayCheckInOut.Columns.Clear();
            dgvTodayCheckInOut.Columns.Add("Activity", "Activity");
            dgvTodayCheckInOut.Columns.Add("Details", "Details");
            dgvTodayCheckInOut.Rows.Add("No arrivals or departures", today.ToString("MMM d"));
        }
    }

    private void UpdateMaintenanceAlerts()
    {
        listView1.BeginUpdate();
        listView1.Clear();
        listView1.View = View.Details;
        listView1.FullRowSelect = true;
        listView1.Columns.Add("Room", 100);
        listView1.Columns.Add("Status", 220);

        var maintenanceRooms = _rooms
            .Where(room => room.Status == RoomStatus.Maintenance)
            .OrderBy(room => room.RoomNumber)
            .ToList();

        if (maintenanceRooms.Count == 0)
        {
            listView1.Items.Add(new ListViewItem(["—", "No rooms need attention"]));
        }
        else
        {
            foreach (var room in maintenanceRooms)
                listView1.Items.Add(new ListViewItem([$"Room {room.RoomNumber}", "Maintenance"]));
        }

        listView1.EndUpdate();
    }

    private void UpdateCharts()
    {
        label4.Text = "Room Type Distribution";
        label8.Text = "Reservations - Last 6 Months";
        label12.Text = "Booked Revenue - Last 7 Days";

        pieChart1.Location = new Point(19, 47);
        pieChart1.Size = new Size(
            materialCard6.ClientSize.Width - 38,
            materialCard6.ClientSize.Height - 60);
        pieChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
        pieChart1.Series = _rooms
            .GroupBy(room => room.RoomType)
            .OrderBy(group => group.Key)
            .Select(group => new PieSeries<int>
            {
                Name = group.Key.ToString(),
                Values = [group.Count()]
            })
            .ToArray();

        var currentMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        var monthStarts = Enumerable.Range(0, 6)
            .Select(offset => currentMonth.AddMonths(offset - 5))
            .ToList();
        var reservationCounts = monthStarts
            .Select(month => _reservations.Count(reservation =>
                !IsCancelled(reservation.ReservationStatus) &&
                reservation.CheckInDate.Date >= month &&
                reservation.CheckInDate.Date < month.AddMonths(1)))
            .ToArray();

        cartesianChart1.Location = new Point(19, 43);
        cartesianChart1.Size = new Size(
            materialCard8.ClientSize.Width - 38,
            materialCard8.ClientSize.Height - 60);
        cartesianChart1.Series =
        [
            new ColumnSeries<int>
            {
                Name = "Reservations",
                Values = reservationCounts
            }
        ];
        cartesianChart1.XAxes =
        [
            new Axis
            {
                Labels = monthStarts.Select(month => month.ToString("MMM")).ToArray()
            }
        ];
        cartesianChart1.YAxes =
        [
            new Axis { Name = "Reservations", MinLimit = 0, MinStep = 1 }
        ];

        var chartStart = DateTime.Today.AddDays(-6);
        var chartDates = Enumerable.Range(0, 7)
            .Select(offset => chartStart.AddDays(offset))
            .ToList();
        var dailyRevenue = chartDates
            .Select(date => _reservations
                .Where(reservation => !IsCancelled(reservation.ReservationStatus))
                .Sum(reservation => GetRevenueInPeriod(
                    reservation,
                    date,
                    date.AddDays(1))))
            .Select(value => (double)value)
            .ToArray();

        cartesianChart2.Location = new Point(19, 58);
        cartesianChart2.Size = new Size(
            materialCard7.ClientSize.Width - 38,
            materialCard7.ClientSize.Height - 74);
        cartesianChart2.Series =
        [
            new LineSeries<double>
            {
                Name = "Booked Revenue",
                Values = dailyRevenue
            }
        ];
        cartesianChart2.XAxes =
        [
            new Axis
            {
                Labels = chartDates.Select(date => date.ToString("ddd d")).ToArray()
            }
        ];
        cartesianChart2.YAxes =
        [
            new Axis { Name = "Revenue", MinLimit = 0 }
        ];
    }

    private static bool IsReserved(string status) =>
        status.Equals("Reserved", StringComparison.OrdinalIgnoreCase);

    private static bool IsCancelled(string status) =>
        status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase);

    private static decimal GetRevenueInPeriod(
        ReservationModel reservation,
        DateTime periodStart,
        DateTime periodEnd)
    {
        var start = reservation.CheckInDate.Date > periodStart
            ? reservation.CheckInDate.Date
            : periodStart;
        var end = reservation.CheckOutDate.Date < periodEnd
            ? reservation.CheckOutDate.Date
            : periodEnd;

        return end > start
            ? (end - start).Days * reservation.PricePerNight
            : 0m;
    }
}
