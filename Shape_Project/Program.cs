namespace Shape_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2, 5);
            Circle c = new Circle(10);
            Cylinder r = new Cylinder(20,10);                 
            
            Console.WriteLine(p);
            
            c.GetDiameter(10);
            c.GetCircumference(10);
            c.GetArea(10);
            Console.WriteLine(c);
                        
            r.GetCircumference(10);
            r.GetVolume(20,10);
            r.GetArea(20,10);
            Console.WriteLine(r);
            

        }
    }
}