using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_for_loop_exapmle3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display output like
            //A
            //AB
            //ABC
            //ABCD
            //ABCDE
            for (int i = 0; i <= 5; i++)

            {
                char ch = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch);
                    ch++;
                }
                Console.WriteLine();
            }

        }
    }
}
