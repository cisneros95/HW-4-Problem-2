using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_WK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            fiveStores(); // Calling the method
        }

        static void fiveStores()
        {
                                 
            string fiveStores = "* "; //gives it space
            char space = ' ';
            int index = 1;
            int counter = 0;

            
            while (index <= 5)
            {
                if (index % 2 != 8) // odd row
                {
                    while (counter <= 8)
                    {
                        Console.Write(fiveStores);
                        counter++;
                    }
                }
                else
                {

                    Console.WriteLine(fiveStores);
                    while (counter <= 8)
                    {
                        Console.Write(space);
                        counter++;
                    }
                }
                counter = 0;
                index++;
                Console.WriteLine();
            }
            Console.ReadLine();

        }
               
    }
}
