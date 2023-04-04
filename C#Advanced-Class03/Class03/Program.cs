using Class03.Entities;
using Class03.Utils;
using System;
using System.Runtime.ConstrainedExecution;

namespace Class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static classes basic
            Console.WriteLine("Hello, World!");
            //Vo staticka klasa mora se da e static
            //Vo obicna klasa moze da ima i static metodi i propertinja, no moze da ima i static

            //Od Statickata klasa ne moze da se kreira objekt

            //Console.WriteLine("Hello World!"); //Console e staticka klasa
            //Console.WriteLine(Math.PI); //Math e staticka klasa

            //Console.WriteLine(FirstStaticClass.Counter); //Default value of int
            //Console.WriteLine(FirstStaticClass.AddTwoNumbers(26, 36));

            //FirstStaticClass.Counter++;
            //Console.WriteLine(FirstStaticClass.Counter);

            //FirstStaticClass.WriteLine(FirstStaticClass.Counter.ToString()); //so statickiot metod WriteLine 

            //Console.WriteLine(StringUtils.CapitaliseFirstLetter("today is raining :("));
            //Console.WriteLine(StringUtils.CapitaliseFirstLetter("Today"));
            //Console.WriteLine(StringUtils.CapitaliseFirstLetter("T"));

            Console.WriteLine("Please enter a number:");
            int number = StringUtils.VerifyStringNumber(Console.ReadLine());

            if (number != -1)
                Console.WriteLine($" The number is: {number}");
            #endregion

            #region Static members in non static classes
            User user1 = new User(1, "Moby", "Dick"); //koga imame staticki member moze da se pristapi direktno od klasata primer User.
            User.UserCount++;
            User user2 = new User(345, "Bob", "Dick");
            User.UserCount++;
            user1.PrintInfo(); //koga imame obicen member mora so instancata od klasata
            

            User.PrintUserCount(); //


            #endregion

            Dog dog = new Dog("Bucky", "Labrador");
            Cat cat = new Cat("Moby", "Gray");

            dog.Eat();
            cat.Eat(); //polymorphism dozvoluva da imame isti metodi so isto ime i najrazlicna primena, no so razlicni input parametki 

            cat.Eat();
        }

        
    }
}