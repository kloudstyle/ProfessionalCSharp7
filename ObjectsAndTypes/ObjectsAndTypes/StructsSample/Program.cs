using System;

namespace StructsSample
{
    class Program
    {
        static void Main()
        {
            var point = new Dimensions(3, 6);
            Console.WriteLine(point.Diagonal);
            Console.ReadLine();
        }
    }
}
