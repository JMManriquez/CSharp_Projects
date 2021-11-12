using System;
using System.Collections.Generic;
using System.Text;

namespace JMM_ECE2310_Final
{
    class GraphObject
    {
        //Data Members
        protected double area;
        protected double perimeter;
        //Constructors
        public GraphObject()
        {
            area = 0;
            perimeter = 0;
        }
        public GraphObject(double x, double y)
        {
            area = x;
            perimeter = y;
        }

        //Getter/Setters Interacting Member Methods for Data Members
        public double Area
        {
            get { return area; }
            set
            {
                if (value < 0) area = 0;
                else area = value;
            }
        }
        public double Perimeter
        {
            get { return perimeter; }
            set
            {
                if (value < 0) perimeter = 0;
                else perimeter = value;
            }
        }
        //Member Methods
        public virtual double cal_area()
        {
            return area; 
            //No code body declared since the child classes will implement their own specific version
        }
        public virtual double cal_perimeter()
        {
            return perimeter;
        }
        //ToString Printing Override
        public override string ToString()
        {
            return "has area:\t\t" + area + "u and perimeter:\t" + perimeter + "u";
        }
        //Destructor
        ~GraphObject() { }
    }

}
