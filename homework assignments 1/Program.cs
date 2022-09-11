using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_assignments_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // different patterns using nested for loop
            //disply output like   1
            //12
            //123
            //1234
            //12345

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}
