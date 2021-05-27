using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class MenuBraniMusicali
    {
        public static int Menu()
        {
            Console.WriteLine("1 - Inserisci nuovo brano");
            Console.WriteLine("2 - Stampa le caratteristiche del brano");
            Console.WriteLine("0 - Premi 0 per uscire");

            int scelta = Convert.ToInt32(Console.ReadLine());
            return scelta;
          

        }
        public static void AnalizzaScelta(int scelta, ref BranoMusicale brano)//utilizzo il valore di scelta(e gia un valore stabilito
        {
           // BranoMusicale branoInserito = new BranoMusicale();

            switch (scelta)
            {
                case 1:
                      brano = InserimentoBranoMusicale();
                    break;
                case 2:
                    StampaBranoMusicale(brano.ToString());
                    //StampaBranoMusicale(brano); è la variabile
                    //metodo per la stampa del brano
                    break;
                default:
                    break;
            }

        }

        private static void StampaBranoMusicale(string brano)
        {
            Console.WriteLine(brano);
            //Console.WriteLine(brano.ToString()); se avessi passato in input il brano musicale per intero con tutte le sue caratterstiche la interno
        }

        private static BranoMusicale InserimentoBranoMusicale()
        {
            BranoMusicale branoMusicale = new BranoMusicale();
            Console.WriteLine("Inserisci il titolo del brano");
            branoMusicale.Titolo = Console.ReadLine();
            Console.WriteLine("Inserisci la durata");
            branoMusicale.Durata = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci l'artista");
            branoMusicale.Artista = Console.ReadLine();
            Console.WriteLine("Inserisci il genere musicale: 0 per Rock, 1 per Pop, 2 per Metal, 3 per Rap o 4 per Indie ");

            branoMusicale.Genere = (GenereMusicale)Convert.ToInt32(Console.ReadLine());
            

            return branoMusicale;
        }
    }
}
