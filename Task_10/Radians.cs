using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Radians
    {
        int Grade;
        int Minutes;
        int Seconds;

        public int grade
        {
            get
            {
                return Grade;
            }
            set
            {
                Grade = value % 360;
            }

        }

        public int minutes
        {
            get
            {
                return Minutes;
            }
            set
            {
                grade += value / 60;
                Minutes = value % 60;
            }

        }
        public int seconds
        {
            get
            {
                return Seconds;
            }
            set
            {
                minutes += value / 60;
                Seconds = value % 60;
            }

        }

        public Radians(int Grade, int Minutes, int Seconds)
        {
            this.Grade = Grade;
            this.Minutes = Minutes;
            this.Seconds = Seconds;

        }
         
        public double ToRadians()
        {
            return (Grade + Minutes / 60 + Seconds / 3600) * (Math.PI) / 180;
        }
    }
}
