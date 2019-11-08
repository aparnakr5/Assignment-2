using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your targeted matured amount?");
            double mat_amt = double.Parse(Console.ReadLine());
            Deposit d = new Deposit();
            d.Calculate(mat_amt);
            Console.ReadKey();
        }
    }
}
