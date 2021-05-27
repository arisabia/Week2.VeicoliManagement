using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    enum GenereMusicale//quando ho diversi opzioni
    {
        Rock,// oppure Rock = 1 cosi parte da 1
        Pop,
        Metal,
        Rap,
        Indie
    }//enumerazione parte da 0
    class BranoMusicale
    {
        public String Titolo { get; set; } = "";
        //convenzione: con la maiuscola!
        public double Durata { get; set; }
        public String Artista { get; set; }
        public GenereMusicale Genere { get; set; }
        //genemusicale e il tipo enum

        public static String Formato = "mp3";
        //con il static
        //tutti i brani di tipo formato avronno la caretteristica mp3

        public bool VersioneLive
        {
            get { return IsVersioneLive(); }
        }
        public bool IsVersioneLive()
        {
            bool live = false;
            if(Durata > 5)
            {
                live = true;
            }
            return live;
        }


        public string ToString()
        {
            string branoLive;
            if(VersioneLive == true)
            {
                branoLive = "Versione concerto";
            }
            else
            {
                branoLive = "Versione CD";
            }
            return $"Titolo: {Titolo} " +
                $"-Durata:{Durata} " +
                $" min -Artista {Artista}" +
                $" -Genere: {Genere} " +
                $"-Versione Live: {branoLive} ";
        }
    }
}
