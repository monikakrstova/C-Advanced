using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Entities
{
    public class Dog : Pet
    {
        public string Breed { get; set; }
        public Dog(string name, string color) : base (name)
        {
            Breed = Breed;
        }
        /// <summary>
        /// This is a method thay will tell that the dog is eating
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("The dog is eating");
        }
    }
}
