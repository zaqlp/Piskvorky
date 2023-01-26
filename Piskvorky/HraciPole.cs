using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky
{
    internal class HraciPole
    {
        public static string[,] policka = new string[15, 15];
        public static int XneboO =0;
        public static void ZapisNaPolicko(int x, int y)
        {
            if (XneboO%2 == 0)
            {
                
                policka[x, y] = "X";
            }
            else
            {
                policka[x, y] = "O";
            }
            
            XneboO++;
        }
        public static bool ZjistiVyhru()
        {
            //string[] nalezenaPole =
              //  policka
                //.Where(x => x == "X");

            return false;
        }
        public static bool ZjistiZapisPolicka(int x, int y)
        {
            if (policka[x, y] == "X" | policka[x, y] == "Y")
            {
                return true;
            }
            return false;
        }
        public static void Vypis()
        {
            int y = 0;
            while (y <= 14)
            {
                int x = 0;
                while (x <= 14)
                {
                    Policko.Vypis(x, y);
                    x++;
                }
                Console.WriteLine();
                y++;
            }
            Console.WriteLine();
        }
        
    }
    
    
}
