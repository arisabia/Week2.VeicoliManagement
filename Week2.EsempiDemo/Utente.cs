using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class Utente
    {
        public String CodiceUtente { get; set; } = "xxxx";
       public String Nome { get; set; } = "xxxx";
        public String Cognome { get; set; } = "xxxx";
        public DateTime DataNascita { get; set; } = new DateTime(2000, 1, 1);


        public String ToString()
        {
            return $"Codice Utente {CodiceUtente}" +
                $"\n Nome: {Nome} " +
                $"\n Cognome: {Cognome}" +
                $"\n DataNascita: {DataNascita.ToShortDateString()}";
            //ToShortDateString() per stampare solo la data senza tempo
        }

    }
}
