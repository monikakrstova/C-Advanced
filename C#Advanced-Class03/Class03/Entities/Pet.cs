using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Entities
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public Pet(string name)
        {
            Name = name;
        }
        /// <summary>
        /// This is a method thay will tell that the pet is eating
        /// </summary>
        /// 
        // This comment is useless because you can instantiate from abstract class
        public abstract void Eat();
    }
}
