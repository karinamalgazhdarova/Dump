using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOPFirst
{
    [DataContract]
    public class Airport
    {   [DataMember]
        private LinkedList<Plane> planes;
        [DataMember]
        private IList<Fligh> flights;

        //1. Сохранить всех текущих работников аэропорта
        //2. Сохранить всех текущих зарегистрированных пассажиров

        //1*. Сделать функцию выдающую состав смены на день (1 случайный Security, 
        // 1 постоянный директор, 2 случайных контроллера)
        //2*. Функция подсчета женщин и детей среди пассажировв

        public Airport()
        {
            planes = new LinkedList<Plane>();
            flights = new List<Fligh>();
        }

        public void arrive(Plane plane)
        {
            if (planes.Count == 0) {
                planes.AddFirst(plane);
            }
            else
            {
                planes.AddLast(plane);
            }
            Console.WriteLine($"Tu-du-tuuun. {plane} has arrived");
        }

        public void departure(Plane plane)
        {
            planes.Remove(plane);
            Console.WriteLine($"Tu-du-tuuun. {plane} has departured");
        }

        public void showCurrentPlanes()
        {
            foreach(Plane plane in planes)
            {
                Console.WriteLine(plane);
            }
        }

        public void registerFlight(Fligh fligh)
        {
            flights.Add(fligh);
        }

        public void removeFlight(Fligh fligh)
        {
            flights.Remove(fligh);
        }

        public Boolean searchFlightByNum(String flightNum, out Fligh retFligh)
        {
            foreach(Fligh fligh in flights)
            {
                if (fligh.getNumber().Equals(flightNum))
                {
                    retFligh = fligh;
                    return true;
                }
            }
            retFligh = null;

            return false;
        }
    }
}
