using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class MethodPoly
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int AddNumbers (int a, int b) //Methods can have same name and return type, but must have different number of inputs
            //or same number of inputs but with different types
        {
            return a + b;
        }
        public int AddNumbers (int first, int second, int third)
        {
            return first + second + third;
        }

        public int AddNumbers (string first, string second) 
        {
            return int.Parse(first) + int.Parse(second);
        }

        public void AddNumbers(double first, double second)
        {
            Console.WriteLine(first + second);
        }
        public double AddNumbers(double first, double second, double third)
        {
            return first + second;
        }
        public double AddNumbers (int first, double second)
        {
            return first + second;
        }
        public double AddNumbers(double first, int second)
        {
            return first + second;
        }
    }
}
