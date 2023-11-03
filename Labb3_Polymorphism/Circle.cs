using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
       
        public Circle() : base()
        {
            Radius = 6;
            
        }

        public override double Area()
        {
            double area = Radius * Radius * Math.PI;
            
            return Radius * Radius * Math.PI;
        }
    }
}
