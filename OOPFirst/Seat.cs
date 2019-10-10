using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class Seat : IComparable
    {
        public short number;

        public Passenger passenger
        {
            get;set;
        }

        public bool isVip;

        public Seat(short number, bool isVip)
        {
            this.number = number;
            this.isVip = isVip;
        }

        public bool isLocked()
        {
            return passenger != null;
        }

        public override string ToString()
        {
            return $"Number : {number} , isVip : {isVip}, Passenger : {passenger}";
        }

        int IComparable.CompareTo(object obj)
        {
            if(obj is Seat)
            {
                Seat inSeat = (Seat)obj;

                if (!this.isLocked() && inSeat.isLocked())
                {
                    return 1;
                }

                if (this.isLocked() && !inSeat.isLocked())
                {
                    return -1;
                }

                return 0;
            } else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
