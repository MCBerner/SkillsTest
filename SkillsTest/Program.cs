using System;

namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("Opgave 2 Opret klassen Booking");
            Console.WriteLine();
            Booking b1 = new Booking(1, new DateTime(2024, 6, 21, 14, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0), 8);
            Booking b2 = new Booking(2, new DateTime(2024, 6, 21, 16, 0, 0), new DateTime(2024, 6, 21, 18, 0, 0), 8);
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            Console.WriteLine("");
            Console.WriteLine("Opgave 3 Opret klassen GymhHall");
            //"Id: {ID}, Navn: {Name}, Adresse {Adress}, Telefonnummer: {Phone}, Email: {Email} "
            GymHall gh1 = new GymHall(1, "Lille gymnastiksal", "Idrætsgade 1", "45 36 36 36", "gym1@gym.dk");
            GymHall gh2 = new GymHall(1, "Store gymnastiksal", "Idrætsgade 2", "45 37 37 37", "gym2@gym.dk");

            Console.WriteLine(gh1);
            Console.WriteLine(gh2);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Opgave 4: Udvid Tilmeldingskatalog klassen med nogle CRUD metoder");
            Console.WriteLine("Creating catalog");
            GymHall tgh1 = new GymHall(1, "Lille gymnastiksal", "Idrætsgade 1", "45 36 36 36", "gym1@gym.dk");

            //Console.WriteLine();
            //Console.WriteLine("Opgave 4 Tilføj booking:");
            //tgh1.RegisterBooking(b1);
            //tgh1.RegisterBooking(b2);
            //Console.WriteLine(tgh1);

        }
    }
}
