#define DEBUG
using System;
using static System.Console;
namespace HelloWorld
{ 
   
    class Program
    {
        int j = 20;

        class Vehicle
        {
            public string Type { get; set; }
            public static explicit operator Brand(Vehicle v)
            {
                Brand Audi = new Brand() { Model = v.Type };
                return Audi;
            }
        }

        class Brand
        {
            public string Model { get; set; }
            public static explicit  operator Vehicle(Brand b)
            {
                Vehicle Car = new Vehicle() { Type = b.Model };
                return Car;
            }
        }

        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            var name = "Bugs Bunny";
            var age = 25;

            var isRabbit = true;
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();
            Console.WriteLine($"name is of type {nameType}");
            Console.WriteLine($"age is of type {ageType}");
            Console.WriteLine($"isRabbit is of type {isRabbitType}");
            int j = 30;
            WriteLine(j);

            
     
            #if DEBUG
                WriteLine("DEBUG");
#endif

            Brand b = new Brand();
            b.Model = "Audi A8";

            Vehicle v = (Vehicle)b;      // Brand to Vehicle conversion --- Explicit using cast
            Console.WriteLine(v.Type);

            Vehicle v1 = new Vehicle();
            v1.Type = "Facelift";

            Brand b2 = (Brand)v1;        // Vehicle to Brand conversion --- Explicit using casts
            Console.WriteLine(b2.Model);

            unsafe
            {
                float* pArr3 = stackalloc float[] { 1.1F, 3.2F, 43.7F };
                for (int i = 0; i < 3; i++)
                {
                    WriteLine(pArr3[i]);
                }
            }

        }   
    }
}
