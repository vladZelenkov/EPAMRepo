using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Round
    {
        private int _x = 0;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value < 0 || value > 1000 ? 0 : value;
            }
        }
        private int _y = 0;
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value < 0 || value > 1000 ? 0 : value;
            }
        }
        private int _radius = 0;
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value < 0 || value > 1000 ? 0 : value;
            }
        }
        public double Lenght
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }
        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public Round()
        {

        }

        public Round(int parX, int parY, int parRadius)
        {
            X = parX;
            Y = parY;
            Radius = parRadius;
        }
    }
}
