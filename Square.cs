using System;
using System.Collections.Generic;
using System.Text;

namespace JMM_ECE2310_Final
{
    class Square : GraphObject //Inheritance from GraphObject
    {
        //Data Members
        private int segment;
        //Constructors
        public Square() : base()
        {
            segment = 0;
        }
        public Square(int s) : base()
        {
            segment = s;
        }
        public Square(int s, double x, double y) : base(x, y)
        {
            segment = s;
        }
        //Getter/Setters Interacting Member Methods for Data Members
        public int Segment
        {
            get { return segment; }
            set
            {
                if (value < 0) segment = 0;
                else segment = value;
            }
        }
        //Member Methods for Calculating Area and Perimeter
        public override double cal_area()
        {
            area = Math.Round((Convert.ToDouble(segment) * Convert.ToDouble(segment)),
           2);
            return area;
        }
        public override double cal_perimeter()
        {
            perimeter = 4 * segment;
            return perimeter;
        }
        //ToString Printing Override
        public override string ToString()
        {
            return "Square\t with segment:\t\t\t" + segment + "u " + base.ToString();
        }
        ~Square() { }
    }
}
