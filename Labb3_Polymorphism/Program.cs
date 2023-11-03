namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();
            List<Geometry> geometries = new List<Geometry> { circle, rectangle, square };


            foreach (Geometry geom in geometries)
            {
                Console.WriteLine($"Area of {geom.GetType().Name} = {geom.Area():0.00}");
            }

           

            Console.ReadKey();

        }
    }
}