using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;


            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            //---------------------part 2 of exercise----------

            var r = 30;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfCircle}");
                
            


        }
    }
}
