using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Deposit
    {
        double principle = 1000.00d;
        double irate = 0.05d;
        double interest;


        public void Calculate(double x)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine(String.Format("{0,-5} |{1,-48} |{2,-25}", "Year", "Interest for the year", "End of the year amount"));
            Console.WriteLine("**********************************************************************************************");
            for (int i = 1; principle <= x; i++)

            {

                interest = principle * irate;


                //Console.WriteLine(i + "     " + principle + "*" + irate + "=" + interest + "                      " + (principle + interest));
                Console.WriteLine(String.Format("{0,-4}  |{1,-18} *  {2,-2}={3,-20}  |{4,-10}", i, principle, irate, interest, (principle + interest)));
                principle += interest;


            }
        }
    }
}
