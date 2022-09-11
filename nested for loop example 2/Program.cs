using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_for_loop_example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // different patterns using nested for loop
            // display output
            //12345
            //1234
            //123
            //12
            //1

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }


        }
    }
}
