namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            s.SpeedUp();

            Console.WriteLine(s.Describe());

            Truck t = new Truck(45, 500);
            t.SpeedUp();

            Console.WriteLine(s.Describe());

            Console.WriteLine("Hello, World!");
        }
    }
}
