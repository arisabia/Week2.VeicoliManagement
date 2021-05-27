using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    class Esercizi
    {
        #region Iterazione VS Ricorsione
        //metodo di Fibonacci
        // 0.. 1... 1.. 2... 3.. 5... 8.. 13...
        //0+1=1, 1+2=3, 3+2= 5; 

        public static int FibonacciIterativo(int n)
        {
            int primoNumero = 0;
            int secondoNumero = 1;
            int result = 0;

            if(n == 0)
            {
                return primoNumero;//chiudo il programma con il return
            }
            if(n == 1)
            {
                return secondoNumero;
            }
            for(int i = 2; i <= n; i++)
            {
                result = primoNumero + secondoNumero;
                //adesso devo cambiare i valori 
                primoNumero = secondoNumero;
                secondoNumero = result;
            }

            return result;

        }

        public static int FibbonacciRicorsivo(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            return FibbonacciRicorsivo(n - 1) + FibbonacciRicorsivo(n - 2);
        }
        // ottnego lo stesso risulato ma ocuppo piu memoria
        #endregion

        #region CLONE
        public static void EsempioClone()
        {
            Persona p = new Persona()
            {
                Nome = "MArio",
                Cognome = "Rossi",
                Eta = 18
            };
            Persona p2 = p;
            //ottengo la stessa istanza un altra reference

            Console.WriteLine("Contenuto di p: {0}", p.ToString());
            Console.WriteLine("Contenuto di p2: {0}", p2.ToString());
            //copio solo l'indirizzo di memoria
            p.Cognome = "Rossini";
            Console.WriteLine("Contenuto di p: {0}", p.ToString());
            Console.WriteLine("Contenuto di p2: {0}", p2.ToString());

        }
        #endregion

        #region EREDITARIETA'
        public static void EsempioEreditarieta()
        {
            Studente s = new Studente()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Eta = 28,
                Matricola = "00100"
            };
            Console.WriteLine("Stipendio ->{0}", s.CalcolaStipendio());
            Persona p = new Persona()
            {
                Nome = "Luigi",
                Cognome = "Verdi",
                Eta = 20
            };
            //con p richama il toString
            Console.WriteLine(p);
            //Console.WriteLine(p.ToString());
            //se il to string non ha la parola override

            Console.WriteLine(s);

            Impiegato i = new Impiegato()
            {
                Nome = "giulia",
                Cognome = "Bianchi",
                Eta = 30,
                Mansione = "Junior"
            };

            Console.WriteLine(i);
            #endregion
        }
            #region EXCEPTON

            public static bool EsempioException()
            {
            int a = 0;
            bool esito = true;
            try
            {
                a = Convert.ToInt16(Console.ReadLine());
                esito = true;
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Inserisci un umero e non una stringa");
                esito = false;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Inserisci un numero più picolo");
                esito = false;
            }
            catch (Exception ex)
            {
                esito = false;
            }
            finally
            {
                a =0;
            }
            return esito;
        }

        public static void EccezioneLanciata()
        {
            Persona p = new Persona()
            {
                Nome = "Mario",
                Cognome = "1Rossi",
                Eta = 25
            };
            try
            {
                p.CalcolaStipendio();
            }catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        #endregion

    }
}
