using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_for_loop_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // different patterns using nested for loop
            //display output like   54321
                                  //5432
                                  //543
                                  //54
                                  //5

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            

        }
    }
}
