using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst

{  
    public class Ticket
    {  
       String flightNumber;
      
       long ticketNumber;
        
        DateTime dateFlight;
       
        DateTime dateIncome;
      
        DateTime dateArrival;
      
        short seatNum;
        Passenger passenger;

        public Ticket()
        {
        }

        public Ticket(string flightNumber, long ticketNumber, DateTime dateFlight, DateTime dateIncome, DateTime dateArrival, short seatNum, Passenger passenger)
        {
            this.flightNumber = flightNumber ?? throw new ArgumentNullException(nameof(flightNumber));
            this.ticketNumber = ticketNumber;
            this.dateFlight = dateFlight;
            this.dateIncome = dateIncome;
            this.dateArrival = dateArrival;
            this.seatNum = seatNum;
            this.passenger = passenger ?? throw new ArgumentNullException(nameof(passenger));
        }

        public override string ToString()
        {
            return String.Format("flightNumber: {0} \n " +
                                 "ticketNumber: {1} \n" +
                                 "dateFlight: {2} \n" +
                                 "dateIncome: {3} \n" +
                                 "dateArrival: {4} \n" +
                                 "seatNum: {5} \n" +
                                 "passenger: {6} \n",
                                 this.flightNumber,
                                 this.ticketNumber,
                                 this.dateFlight,
                                 this.dateIncome,
                                 this.dateArrival,
                                 this.seatNum,
                                 this.passenger);
        }
    }
}
