using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");

            string  no = Console.ReadLine();
            try
            {
                int num = int.Parse(no);
                Console.WriteLine("Number is ...." + no);
            }
            catch(FormatException ex) {
                Console.WriteLine("string format is wrong");
            }
            Console.ReadLine();
        }
    }
}
