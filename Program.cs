using System.Runtime.InteropServices;
using Hotel_Management.State;
using Hotel_Management.Repositories;
using Hotel_Management.Services;
using Hotel_Management.Data;


namespace Hotel_Management
{
    static class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            // 1. Open the console window when running in Debug mode
        #if DEBUG
            NativeMethods.AllocConsole();
            Console.WriteLine("==> Console initialized successfully!");
        #endif
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Create instance stateModel for share data with UI

            var stateModel = new StateModel();

            var roomRepository = new RoomRepository();

            var roomService = new RoomService(roomRepository, stateModel);

            roomService.LoadRoom();


            Application.Run(new Main());
        }
    }
}