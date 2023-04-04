using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Entities
{
    internal class Cat : Pet
    {
        public  string  Color { get; set; }
        public Cat(string name, string color) : base (name)
        {
            Color = color;
        }
        /// <summary>
        /// This is a method thay will tell that the cat is eating
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("The cat is eating");
        }
    }
}
