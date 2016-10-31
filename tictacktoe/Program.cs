using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictacktoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[11];
            array1[0] = "   |   |   ";
            string[] array2 = new string[11];
            array2[0] = "---|---|---";

            for (int i = 0; i < 11; i = i + 1)
            {
                Console.WriteLine(array1[i]);
                Console.WriteLine(array2[i]);
                Console.WriteLine(array1[i]);
                Console.WriteLine(array2[i]);
                Console.WriteLine(array1[i]);
                
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
