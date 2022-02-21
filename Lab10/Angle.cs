using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value >= 360)
                {
                    gradus = value % 360;
                }
                else
                {
                    gradus = value;
                }
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public double ToRadian()
        {
            return (gradus + (double)min / 60 + (double)sec / 60 / 60) * Math.PI / 180;
        }
    }
}
