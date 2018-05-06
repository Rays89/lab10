using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
       private double radius;
       
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }


        //this one will calculate circumference and give all numbers after decimal point
        public double CalculateCircumference()
        {

            double circumference = 2 * (3.14 * Radius);//you call the big radius coz its public
            return circumference;

        }
        //this one will calculate circumference and give you only two numbers after the decimal point
        public string calculateFormattedCircumference()
        {
            double circumference = 2 * (3.14 * Radius);
            return ($"{circumference, 0:N2}");//N2 means tow numbers after decimal places 
        }

        public double CalculateArea()
        {
            double Area = 3.14 * (Radius * Radius);
            return Area;


        }
            

    }
}