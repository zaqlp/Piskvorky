using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky
{
    internal class Hra
    {

        public void Start()
        {
            HraciPole.Vypis();
            Console.WriteLine("Dej Koordinace X,Y");
            while (true)
            {
                if (HraciPole.ZjistiVyhru() == true)
                {
                    //Console.WriteLine($"Mame vítěze {JeDohrano()}, hra skončila ");
                    break;

                }
                string[] Koordinace;
                string e =Console.ReadLine();
                if (e == null) { continue; }
                
                Koordinace = e.Split(',');
                Console.WriteLine(Koordinace[0] +Koordinace[1]);
                if(HraciPole.ZjistiZapisPolicka(int.Parse(Koordinace[0]), int.Parse(Koordinace[1])))
                {
                    continue;
                }
                HraciPole.ZapisNaPolicko(int.Parse( Koordinace[0]), int.Parse(Koordinace[1]));
                
                
                    HraciPole.Vypis();

                
            }
        }
            
    }
}
