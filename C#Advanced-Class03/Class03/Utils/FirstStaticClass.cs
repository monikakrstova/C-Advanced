using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Utils
{
    public static class FirstStaticClass
    {
        public static int Counter { get; set; }

        static FirstStaticClass()
        {
            Counter = 1; //Inicijalizacija na property vo konstruktorot
        }

        public static int AddTwoNumbers (int x, int y)
        {
            return x + y;
        }

        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
