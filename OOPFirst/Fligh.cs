using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class Fligh
    {
        public enum FlightSchedule
        {
            DAILY, WEEK, MONTH, FREE
        }

        private String[] campanies;
        private String number;

        public String getNumber()
        {
            return number;
        }

        private String from;
        private String to;
        private FlightSchedule schedule;

        public Fligh(string[] campanies, string number, string from, string to, 
                     FlightSchedule schedule)
        {
            this.campanies = campanies ?? throw new ArgumentNullException(nameof(campanies));
            this.number = number ?? throw new ArgumentNullException(nameof(number));
            this.from = from ?? throw new ArgumentNullException(nameof(from));
            this.to = to ?? throw new ArgumentNullException(nameof(to));
            this.schedule = schedule;
        }

        public override string ToString()
        {
            return $"{number}, {campanies}, {from}, {to}, {schedule}";
        }
    }
}
