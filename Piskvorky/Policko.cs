using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky
{
    internal class Policko
    {
        
        public static void Vypis(int x ,int y)
        {

            Console.Write("[");

            if (HraciPole.policka[x, y] == "O")
            {
                Console.Write("O");
            }
            else
            {
                if (HraciPole.policka[x, y] == "X")
                {
                    Console.Write("X");
                }
                else
                {
                    
                        Console.Write(" ");

                    
                }
            }

            Console.Write("]");

        }
    }
}
