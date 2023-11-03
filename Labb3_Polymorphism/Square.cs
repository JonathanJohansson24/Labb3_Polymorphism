using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    internal class Square : Geometry
    {
        public double SquareSide { get; set; }
       

        public Square() : base()
        {
            SquareSide = 6;
            
        }
        public override double Area()
        {
            
            
            return SquareSide * SquareSide;
        }
    }
}
