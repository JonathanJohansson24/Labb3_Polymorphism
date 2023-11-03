using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Base {  get; set; }
        public double Height { get; set; }
       

        public Rectangle() : base()
        {
            Base = 4;
            Height = 10;
            
        }

        public override double Area()
        {
            
            return Base * Height;
        }
    }
}
