using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ring : Round
    {
        private int _innerRadius;
        public int InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                _innerRadius = value > 0 || value < 1000 ? value : Radius;
            }
        }
        public double RingArea
        {
            get
            {
                return Area - Math.PI * InnerRadius * InnerRadius;
            }
        }
        public double RindLenght
        {
            get
            {
                return Lenght + 2 * Math.PI * InnerRadius;
            }
        }

        public Ring()
        {

        }

        public Ring(int parX, int parY, int parRadius, int parInnerRadius) :
            base(parX, parY, parRadius)
        {
            InnerRadius = parInnerRadius;
        }

        public override string ToString()
        {
            string rez = $"X = {X}| Y = {Y}| Radius = {Radius}| InnerRadius = {InnerRadius}\n RingArea = {RingArea:F3}| RingLength = {RindLenght:F3}";
            return rez;
        }
    }
}
