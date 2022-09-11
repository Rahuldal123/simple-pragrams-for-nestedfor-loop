using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_for_loop__exapmle_4_star_pyranid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // display output like 
            //*********
            // *******
            //  *****
            //   ***
            //    *
            //    

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= 4; k++)
                {
                    Console.Write("*");
                }
                for(int l=i;l<=3;l++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }   

        }
    }
}
