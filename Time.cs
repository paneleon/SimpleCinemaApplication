using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
    public class Time
    {
        private int hours;
        private int minutes;

        public Time(int hours, int minutes = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public override string ToString()
        {
            return string.Format($"{this.hours:00} : {this.minutes:00}");
        }

        public static bool operator == (Time lhs, Time rhs)
        {  
            if (Math.Abs((lhs.hours * 60 + lhs.minutes) - (rhs.hours * 60 + rhs.minutes)) < 15)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        public static bool operator != (Time lhs, Time rhs)
        {
            if (Math.Abs((lhs.hours * 60 + lhs.minutes) - (rhs.hours + rhs.minutes)) < 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
