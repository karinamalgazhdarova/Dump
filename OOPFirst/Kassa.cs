using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class Kassa
    {
        decimal balance = 10000;

        public Ticket buyTicket(Passenger passenger,
                                long amount,
                                String flightNumber)
        {
            Random random = new Random();

            Ticket ticket = new Ticket( flightNumber, 
                                        random.Next(100000), 
                                        DateTime.Now,
                                        DateTime.Today,
                                        DateTime.UtcNow,
                                        (short)random.Next(50),
                                        passenger);

            balance += amount;

            return ticket;
        }
    }
}
