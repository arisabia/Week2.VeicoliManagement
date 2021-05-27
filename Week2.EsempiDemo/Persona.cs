using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    public class Persona
    {
        //Campi
        //Proprietà (get, set)
        private string _nome;
        //per i campi privati si usa il _
        private double _stipendio = 1000.00;
        private int _eta;
        

        //nella proprieta si scrive con N maiusculo
        public string Nome
        {
            get { return _nome; }// si può recuperare
            set { _nome = value; }//si può modificare
        }

        /* è ugual al java che si fa cosi
         * public string GetNome()
           {
               return _nome;
           }
           public void SetNome(string value)
           {
               _nome = value;
           }*/
        public string Cognome { get; set; }
        //dichiaro tutto in un unico 

        // public string Cognome { get; set; } = "Sacchitella";
        //stabilisco il valore iniziale come "sacchitella"
        //public string Cognome { get; set; } = "";
        //con stringa vuota per evitare errori

        public int Eta
        {
            get { return _eta; }
            set { _eta = value; }
        }
        
        public double Stipendio
        {
            get { return _stipendio; }
        }

        //questa è un altra variante
        public double Stip
        { 
            get { return CalcolaStipendio();
            } 
        }

        //se voglio modificare il valore dello stipendi dall'estero allo lo
        //scrivo cosi:
        public Double StipendioNonCalcolato { get; set; } = 1000.00;
        public DateTime DataNascita { get; set; } = new DateTime(1970, 1, 1);


        //Costruttore
        public Persona() { }
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }


        //Metodi

        internal virtual double CalcolaStipendio()
        {//virtual permette di sovrascrivere
            if (Cognome.StartsWith("1"))
            { //chiamo un eccezione
                throw new ArgumentException("Cognome non valido");
            }
            if(Eta >= 20 && Eta <= 25)
            {
                _stipendio = _stipendio + (_stipendio * 10) / 100;
                //_stipendio += (_stipendio * 10) / 100;
            }
            else
            {
                _stipendio = _stipendio + (_stipendio * 20) / 100;
            }
            return _stipendio;
        }
        //con la parola override posso richiamare il metodo
        //da altri object
        public override string ToString()
        {

            return $"Nome: {Nome} Cognome: {Cognome} Eta: {Eta} Data di Nascita: {DataNascita.ToShortDateString()}";
            //.ToShortDateString scrive solo la data senza l'ora
        }

        public virtual int GetNumber()
        {
            return 7;
        }
    }
}
