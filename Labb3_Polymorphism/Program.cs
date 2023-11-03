namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();


            Console.WriteLine($"Arean av cirkel = {circle.Area()}");
            Console.WriteLine($"Arean av fyrkant = {square.Area()}");
            Console.WriteLine($"Arean av rektangel = {rectangle.Area()}");

            Console.ReadKey();

        }
    }
}