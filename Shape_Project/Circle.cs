using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Project
{ 
    internal class Circle : Point
    {
        protected double radius, diameter, circumference, area;
        public double Radius { get; set; }        
        
        public Circle(double radius)
        {            
            Radius = radius;
        }
        /// <summary>
        /// Returns calculating of diameter
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>DIAMETER</returns>
        public double GetDiameter(double radius)
        {
            diameter = radius * 2;
            return diameter;
        }
        /// <summary>
        /// Returns calculating of circumference, method is virtual for cylinder
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>CIRCUMFERENCE</returns>
        public virtual double GetCircumference(double radius)
        {
            circumference = 2 * Math.PI * radius;
            return circumference;
        }
        /// <summary>
        /// Returns calculating of area
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>AREA</returns>
        public double GetArea(double radius)
        {
            area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        /// <summary>
        /// Text represents a CIRCLE class
        /// </summary>
        /// <returns>Diameter, circumference and area</returns>
        public override string ToString()
        {
            return String.Format($"This is CIRCLE CLASS:\nRadius: {Radius}\nDiameter: {diameter}\nCircumference: {circumference}\nArea: {area}\n");
        }
    }//
}
