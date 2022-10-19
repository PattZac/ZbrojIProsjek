using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbrojIProsjek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciranje objekt
            klasaC klasac = new klasaC();
            Console.WriteLine("Unesite 5 cijelih brojeva.");
            //Unos Broja
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Unesite "+(i+1)+". broj: ");
                try
                {
                    klasac.SetBrojeve(i,Convert.ToInt32(Console.ReadLine()));
                }
                catch(Exception greska)
                {
                    Console.WriteLine("\r\nNeisprava unos, probajte opet!");
                    Console.WriteLine("Greška: "+greska.Message+"\r\n");
                    i--;
                }
            }

            //Ispis
            Console.WriteLine("\r\n"+klasac.Zbroj());
            Console.WriteLine(klasac.Projsek());

            //Kraj
            Console.ReadKey();
        }

        class klasaC
        {
            //Svojstva
            private int[] brojeve = { 0, 0, 0, 0, 0 };
            //Metode
            public void SetBrojeve(int j, int broj)
            {
                this.brojeve[j] = broj;
            }
            public string Zbroj()
            {
                int zbroj = 0;
                for(int i = 0; i<=4; i++)
                {
                    zbroj+= this.brojeve[i];
                }
                return "Zbroj Broja je "+zbroj+".";
            }
            public string Projsek()
            {
                double prosjek = 0;
                for (int i = 0; i <= 4; i++)
                {
                    prosjek += this.brojeve[i];
                }
                return "Prosjek Broja je " + (prosjek/5) + ".";
            }
        }
    }
}
