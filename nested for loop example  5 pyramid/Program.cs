using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_for_loop_example__5_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // display output for pyramid of *


            for(int i = 0; i <=4; i++)
            {
                for(int j=i;j<=4;j++)
                {
                    Console.Write(" ");

                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 1; l <= i; l++)
                {
                    Console.Write("*");
                }

                        

                Console.WriteLine();
            }   
        }
    }
}
