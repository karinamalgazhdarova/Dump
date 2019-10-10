using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class Plane
    {
        public class SeatOutOfRangeException : ApplicationException
        {
            public SeatOutOfRangeException(string message) : base(message)
            {
            }
        }

        //TODO: not ended class
        public string planeNum;

        public string planeModel;

        public string planeCompany;

        private int capacity;

        private Seat[] seats;
        private Passenger[] passengers;

        public override string ToString()
        {
            return $"{planeNum}, {planeModel}, {planeCompany}, {capacity}";
        }

        public Plane(string planeNum, string planeModel, string planeCompany, int capacity)
        {
            this.planeNum = planeNum ?? throw new ArgumentNullException(nameof(planeNum));
            this.planeModel = planeModel ?? throw new ArgumentNullException(nameof(planeModel));
            this.planeCompany = planeCompany ?? throw new ArgumentNullException(nameof(planeCompany));
            this.capacity = capacity >= 0 ? capacity : 10;

            this.seats = new Seat[capacity];
            this.passengers = new Passenger[capacity];
            for(int i = 0; i< capacity; i++)
            {
                seats[i] = new Seat( (short)(i + 1), 
                                     i <= 10 ? true : false);
            }
        }

        public Boolean registerPassengerForSeat(Passenger passenger,
                                                short seatNum)
        {
            /*if(passenger == null)
            {
                return false;
            }

            Seat[] sortedSeats = new Seat[seats.Length];
            Array.Copy(seats, sortedSeats, seats.Length);
            Array.Sort(sortedSeats);

            foreach (Seat seat in sortedSeats)
            {
                if (passenger.Equals(seat.passenger))
                {
                    return false;//or throw Exception
                }
            }*/
            foreach (Passenger pas in passengers)
            {
                if (passenger.Equals(pas))
                {
                    return false;
                }
            }

            if (seatNum > capacity)
            {
                throw new SeatOutOfRangeException($"There is only {capacity} seats in plane");
            }

            Seat acquiredSeat = seats[seatNum];
            if (acquiredSeat.isLocked())
            {
                return false;
            }

            acquiredSeat.passenger = passenger;

            for (int i = 0; i < capacity; i++)
            {
                if(passengers[i] == null)
                {
                    passengers[i] = passenger;
                }
            }

            return true;
        }

        public void printFreePlaces()
        {
            Seat[] sortedSeats = new Seat[seats.Length];
            Array.Copy(seats, sortedSeats, seats.Length);
            Array.Sort(sortedSeats);

            foreach(Seat seat in sortedSeats)
            {
                if (seat.isLocked())
                {
                    break;
                }
                Console.WriteLine(seat);
            }
        }

        public void printPlaces()
        {
            foreach(Seat seat in seats)
            {
                Console.WriteLine(seat);
            }
        }
    }
}
