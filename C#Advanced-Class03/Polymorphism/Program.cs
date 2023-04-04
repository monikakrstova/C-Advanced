using Polymorphism.Models;
using System.Data.Common;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so tri /// moze da se dade objasnuvanje za metoda
            
            Console.WriteLine("Hello, World!");
            MethodPoly poly = new MethodPoly();
           Console.WriteLine( poly.AddNumbers(5, 10));
         Console.WriteLine(poly.AddNumbers("12", "4"));
            Console.WriteLine(poly.AddNumbers(5, 10, 15));
            Console.WriteLine(poly.AddNumbers(3, 3));

            
            
        }
    }
}