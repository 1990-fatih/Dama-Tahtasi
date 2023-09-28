using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dama_Tahtasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j % 2 == 0)

                            Console.Write("0");
                        else
                        {
                            Console.Write("1");
                        }


                    }
                }
                else
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j % 2 == 1)

                            Console.Write("0");
                        else
                        {
                            Console.Write("1");
                        }


                    }
                }
                Console.WriteLine();
            }
        }
    }
}
