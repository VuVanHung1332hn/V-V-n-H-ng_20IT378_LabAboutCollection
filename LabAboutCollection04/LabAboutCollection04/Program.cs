using System;

namespace LabAboutCollection04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leon leons = new Leon();
            // Cats class
            leons.model();
            leons.color();
            leons.Start();
            leons.Stop();

            Tesla teslas = new Tesla();
            // Cats class
            teslas.model();
            teslas.color();
            teslas.Start();
            teslas.Stop();


            Console.ReadLine();
        }
    }
}
