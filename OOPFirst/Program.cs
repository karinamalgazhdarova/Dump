using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;    
using System.Threading.Tasks;

namespace OOPFirst
{
    class Program
    {
        //продажа билетов
        //регистрация пассажиров
        //посадка пассажиров
        //взлет самолета
        //посадка самолета

        //dresscode в аэропорту
        //работники могут носить ключи
        delegate void Message();
       
        static void GoodMorning()
        {
            Console.WriteLine("Good morning");
        }

        static void GoodEvening()
        {
            Console.WriteLine("Good evening");
        }

        static void Main(string[] args)
        {
            Message message;

            if(DateTime.Now.Hour < 12)
            {
                message = GoodMorning;
              
            } else
            {
                message = GoodEvening;
            }

            message();


            Passenger passenger1 =
                new Passenger("Artem", "Pervushov", "Vladimirovich", 
                              1111, 14560987, true, AgeCategory.Adult, 
                              DateTime.Parse("01.03.1990"));
            Passenger passenger2 =
                new Passenger("Denis", "Pervushov", "Artemovich",
                              2222, 1439874389, true, AgeCategory.Child,
                              DateTime.Parse("05.03.2011"));

            Kassa kassa = new Kassa();

            Ticket ticketForArt =
                kassa.buyTicket(passenger1, 100000, "SR111");

            Console.WriteLine(ticketForArt);

      


            Employee[] employees = { new Security("Adam", 25),
                                     new Controller("Maria", 30, "S7"),
                                     new Director("John Conor", 44) };
            employees[0].work();
            employees[1].work();
            employees[2].work();

            //Employee employee = new Employee();
            Employee conreteEmployee = new Security("Andrew", 23);

            LugKeeper lugKeeper1 = new LugMover("Alex", 32);
            LugKeeper lugKeeper2 = new LugTransporter("Peter", 35);

            lugKeeper1.printSalary();
            lugKeeper2.printSalary();
            lugKeeper1.keepLugg();
            lugKeeper2.keepLugg();

            Console.WriteLine(lugKeeper1.getDescription());
            Console.WriteLine(lugKeeper2.getDescription());

          



            Employee director = new Director("Ludvig", 45);
            //Console.WriteLine(director.name);
            //Console.WriteLine(director.tag);
            //director.someProtected();

            Plane plane = new Plane("SN117", "Aerobus", "S7", 100);
            plane.registerPassengerForSeat(passenger1, 10);
            plane.registerPassengerForSeat(passenger2, 11);
            plane.registerPassengerForSeat(passenger1, 12);
            plane.registerPassengerForSeat(passenger2, 13);

            plane.printPlaces();
            plane.printFreePlaces();

            int[,] mas = new int[4,4];
            Random random = new Random();
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    mas[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 1)
                        Console.Write(mas[i, j] + " ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Airport airport = new Airport();
            airport.arrive(plane);
            airport.showCurrentPlanes();
            airport.departure(plane);
            airport.showCurrentPlanes();

            Fligh fligh1 = new Fligh(new String[2] { "Utair", "S7" },
                                                     "SM115", "Moscow", "Omsk",
                                                     Fligh.FlightSchedule.DAILY);
            Fligh fligh2 = new Fligh(new String[2] { "Aeroflot", "BelAvia" },
                                                     "BEL065", "Moscow", "Minsk",
                                                     Fligh.FlightSchedule.WEEK);
            airport.registerFlight(fligh1);
            airport.registerFlight(fligh2);

            Fligh searchedFlight;
            bool success = airport.searchFlightByNum("SM115", out searchedFlight);

            if (success)
            {
                Console.WriteLine($"Found {searchedFlight}");
            }

            Passenger pass = new Passenger("Karina", "Vlasova", "A", 5212, 214563,
                false, AgeCategory.Adult, DateTime.Parse("09.08.1991"));
            XmlWorker.createXMLForPassenger(pass,"pass.txt");

            XmlWorker.readXMLForPassenger();

           
            Console.ReadKey();
        }
    }
}
