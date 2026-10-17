using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management.Models
{
    class RoomTest
    {
        static void Main(string[] args)
        {
            Room r = new Room();

            r.RoomId = 1;
            r.RoomNumber = 101;

            Console.WriteLine($"Room ID: {r.RoomId}");
            Console.WriteLine($"Room Number: {r.RoomNumber}");

            Console.ReadKey();
        }
    }
}