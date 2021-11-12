using System;
using System.Collections.Generic;
using System.Text;

namespace JMM_ECE2310_Final
{
    class RightTriangle : GraphObject //Inheritance
    {
        //Data Members
        private int height;
        private int bas;
        //Constructors
        public RightTriangle() : base()
        {
            height = 0;
            bas = 0;
        }
        public RightTriangle(int h, int b) : base()
        {
            height = h;
            bas = b;
        }
        public RightTriangle(int h, int b, double x, double y) : base(x, y)
        {
            height = h;
            bas = b;
        }
        //Getter/Setters Interacting Member Methods for Data Members
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0) height = 0;
                else height = value;
            }
        }
        public int Bas
        {
            get { return bas; }
            set
            {
                if (value < 0) bas = 0;
                else bas = value;
            }
        }
        //Member Methods for Calculating Area and Perimeter
        public override double cal_area()
        {
            area = Math.Round((0.5 * (Convert.ToDouble(height)) *
           (Convert.ToDouble(bas))), 2);
            return area;
        }
        public override double cal_perimeter()
        {
            // a + b + sqrt(a^2 + b^2
            perimeter = Math.Round(((Convert.ToDouble(height)) + (Convert.ToDouble(bas))
           + Math.Sqrt(Math.Pow(Convert.ToDouble(height), 2) + Math.Pow(Convert.ToDouble(bas), 2))),
           2);
            return perimeter;
        } //ToString Printing Override
        public override string ToString()
        {
            return "Right Triangle with height:\t" + height + "u and with base:\t" + bas
           + "u " + base.ToString();
        }
        //Destructor
        ~RightTriangle() { }

    }
}
