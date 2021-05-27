using System;
using System.Collections;
using System.Diagnostics;

namespace Week2.EsempiDemo
{
    class Program
    {


        private static Utente utente = new Utente();
        private static Bolletta bolletta = new Bolletta();
        //fuori dal main per essere visivone da per tutto

        static void Main(string[] args)
        {
            #region GESTIONE RISORSE
            ArrayList persone = GestioneIO.CaricaPersoneDaFile();
            GestioneIO.StampaPersoneSuFile(persone);//passo l'arrayList per valore


            //Console.WriteLine("Inserisci il nome della cartella che vuoi creare");
            //string directoryName = Console.ReadLine();
            //crea cartella
            //GestioneIO.CreazioneDirectory(directoryName);
            //elimia cartella
            //GestioneIO.EliminaCartella(directoryName);
            //sposta cartella
            //GestioneIO.SpostaCartella();
            //GestioneIO.StampaContenutoCartella();
            //Persona pers = new Persona()
            //{
            //    Nome = "mario",
            //    Cognome = "Rossi",
            //    Eta = 23
            //};
            // GestioneIO.ScritturaFile(pers);

           // GestioneIO.LeggiDaFile();
            Console.ReadLine();


            #endregion


            #region EXCEPTION

            Esercizi.EccezioneLanciata();

            while (!Esercizi.EsempioException())
            {
                Console.WriteLine("Ritenta");
            }
            // Esercizi.EsempioException();
            Console.ReadKey();
            Esercizi.EsempioEreditarieta();
            Esercizi.EsempioClone();

            #endregion

            #region Veicolo
            Veicolo v = new Veicolo() { NumeroRuote = 4, Targa = "de33dd", Telaio = 1232 };
            Automobile auto = new Automobile() { NumeroRuote = 4, Targa = "sk3k33", Interni = "tessuto", Telaio = 222 };

            Moto moto = new Moto()
            {
                Cilindrata = 243,
                Telaio = 233,
                NumeroRuote = 2,
                Targa = "jeif3"
            };

            Console.WriteLine($"Veicolo Generico: {v} -Automobile {auto} - Moto: {moto}");
            Console.ReadKey();//chiedo di leggere

            #endregion


           

            #region Iterazione vs Recorsione

            ////Esercizi.FibonacciIterativo(5);
            ////Esercizi.FibbonacciRicorsivo(5);

            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            ////richiamo fibonacci iterativo
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Esercizi.FibonacciIterativo(i));
            //}
            //watch.Stop();
            //Console.WriteLine("Il metono iterativo ha impiegato {0}", watch.ElapsedMilliseconds);

            //Console.WriteLine();//riga vuota per leggibilità
            //watch.Reset();


            //watch.Start();
            ////richiamo metodo fibonacci ricorsivo
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Esercizi.FibbonacciRicorsivo(i));
            //}
            //watch.Stop();
            //Console.WriteLine("Il metodo ricosivo ha impiegato {0}", watch.ElapsedMilliseconds);

            #endregion

            #region Persona
            //Persona persona = new Persona();
            ////viene inizzalizato a 0 o null per string

            //persona.Nome = "Larisa";
            //persona.Eta = 28;
            ////riciamo il metodo Calcola Stipendio
            //persona.CalcolaStipendio();//incapsulameto

            //Console.WriteLine("Il mio mone è: {0}", persona.Nome);
            //Console.WriteLine("La mia età è: {0}", persona.Eta);
            //Console.WriteLine(" Il mio stipendio è {0} euro", persona.Stipendio);
            //Console.WriteLine("La mia data di nascita {0}", persona.DataNascita);

            //Persona persona2 = new Persona();//istanzia ogg
            ////dichiara ogg vuoto
            //persona2.Nome = "Mario";
            //Console.WriteLine("Il mio nome è: {0}", persona2.Nome);
            //Console.WriteLine("La mia erà è; {0}", persona2.Eta);

            ////dichiaro un oggetto (istanzio)
            ////è solo un altro modo per farlo uguale a  sopra
            //Persona persona3 = new Persona()
            //{
            //    Nome = "Luigi",
            //    Cognome = "Verdi",
            //    Eta = 18,
            //    DataNascita = new DateTime(2000, 12, 7),
            //    StipendioNonCalcolato = 2000
            //};

            //Persona persona4 = new Persona("Giordano", "Bruno", 45);
            //Console.WriteLine("nome: {0} - Cognome: {1} -Età: {2}  -Data di Nascita: {3}",
            //    persona4.Nome, persona4.Cognome, persona4.Eta, persona4.DataNascita);
            ////dataNascita vera presa quella de default

            //Console.WriteLine("Persone inserite");
            //Console.WriteLine(persona.ToString());
            //Console.WriteLine(persona2.ToString());
            //Console.WriteLine(persona3.ToString());
            //Console.WriteLine(persona4.ToString());
            #endregion

            #region BranoMusicale
            /* BranoMusicale branoMusicale = new BranoMusicale();
             Console.WriteLine("Inserisci il titolo del brano");
             branoMusicale.Titolo = Console.ReadLine();
             Console.WriteLine("Inserisci la durata");
             branoMusicale.Durata =Convert.ToDouble( Console.ReadLine());
             Console.WriteLine("Inserisci l'artista");
             branoMusicale.Artista = Console.ReadLine();
             Console.WriteLine("Inserisci il genere musicale: 0 per Rock, 1 per Pop, 2 per Metal, 3 per Rap o 4 per Indie ");

             //bool success = Enum.TryParse(GenereMusicale, Console.ReadLine(), out (GenereMusicale)branoMusicale.Genere);
             branoMusicale.Genere =(GenereMusicale) Convert.ToInt32(Console.ReadLine());
             //transformo l'inero nel enum 
             Console.WriteLine(branoMusicale.ToString());

             BranoMusicale branoMusicale1 = new BranoMusicale()
             {

                 Artista = "jovanotti",
                 Durata = 4.25,
                 Titolo = "bella",
                 Genere = GenereMusicale.Pop

             };*/
            // MenuBraniMusicali.Menu();
            //    int scelta = MenuBraniMusicali.Menu();
            //    BranoMusicale branoNuovo = new BranoMusicale(); 
            //    do
            //    {
            //        MenuBraniMusicali.AnalizzaScelta(scelta, ref branoNuovo);
            //        scelta = MenuBraniMusicali.Menu();//riassegno la variabile scelta

            //    }
            //    while (scelta != 0);
            //}
            // BranoMusicale brano; // =new BranoMusicale();
            // string a = BranoMusicale.Formato;

            #endregion

            #region Bolletta

            ///////////////////////////
            //    private static int MenuBolletta()
            //{
            //    Console.WriteLine("1.Inserisci i tuoi dati");
            //    Console.WriteLine("2.Calcola Bolletta");
            //    Console.WriteLine("3.Stampa Bolletta");
            //    Console.WriteLine("4.Exit");
            //    int scelta = Convert.ToInt32(Console.ReadLine());
            //    //verifico l'input dell'utente
            //    while (scelta < 0 || scelta > 4)
            //    {
            //        Console.WriteLine("Inserisci un valore corretto");
            //        scelta = Convert.ToInt32(Console.ReadLine());
            //    }

            //    return scelta;
            //}
            //private static void InserisciDati()
            //{
            //    Console.WriteLine("Inserisci i tuoi dati");

            //}


            bool continua = true;
            int selezione;

            while (continua)
            {
                selezione = SchermoMenu();
                SchermoVerifica(selezione, ref continua);
                //procedura no return    
            }

        }
        public static int SchermoMenu()
        {
            Console.WriteLine("1. Inserisci i dati");
            Console.WriteLine("2. Stampa bolletta");
            Console.WriteLine("3. Exit");
            int scelta = Convert.ToInt32(Console.ReadLine());
            return scelta;
        }

        public static void SchermoVerifica(int selezione, ref bool continua)
        {
            switch (selezione)
            {
                case 1:
                    SchermoInserimentoDatiUtente();
                    SchermoInserimentoDatiBolletta();
                    // Metodo per l'inserimento della bolletta
                    break;
                case 2:
                    //TODO: stampa
                    SchermoStampaDettagli();
                    break;
                default:
                    continua = false;
                    break;
            }
        }
        public static void SchermoInserimentoDatiBolletta()
        {
            Console.WriteLine("Inserisci tipologia bolletta");
            int[] values = new int[] { 0, 1, 2 };
            foreach (var item in values)
            {
                Console.WriteLine(Enum.GetName(typeof(TipoBolletta), item));
            }
            try { 
            Enum.TryParse(Console.ReadLine(), out TipoBolletta tipo);
            bolletta.Tipologia = tipo;
            Console.WriteLine($"Consumo in {bolletta.UM} \t");
            bool esitoConsumo = InserimentoConsumo(out double consumo);
            while (!esitoConsumo)
            {
                    Console.WriteLine("inser un valore numerico");
                    esitoConsumo = InserimentoConsumo(out consumo);

            }
                bolletta.ConsumoTotale = consumo;

            // bolletta.ConsumoTotale = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci data di scadenza");
           bool esito = DateTime.TryParse(Console.ReadLine(), out DateTime scadenza);
            while (!esito)
            {
                Console.WriteLine("insersici un datda coerente");
                esito = DateTime.TryParse(Console.ReadLine(), out scadenza );
            }
            bolletta.DataScadenza = scadenza;
            bolletta.Utente = utente;
        
        }
        catch(FormatException)
        {
                Console.WriteLine("Inserisci un consumo numerico");
        }
            catch (Exception)
            {
                Console.WriteLine("Ops, c'è stato un erorre");
            }
        }

        public static bool InserimentoConsumo(out double consumo)
        {
            bool esito;
            
            try
            {
                consumo = Convert.ToDouble(Console.ReadLine());
                esito = true;
            }
            catch(FormatException)
            {
                Console.WriteLine("errore di inserimento");
                consumo = 0.0;
                esito = false;
            }
            return esito;


        }
        public static void SchermoInserimentoDatiUtente()
        {

            Console.WriteLine("Inserisci codice utente \t");
            utente.CodiceUtente = Console.ReadLine();

            Console.Write("Inserisci il tuo nome \t");
            utente.Nome = Console.ReadLine();
            Console.Write("Inserisci cognome \t");
            utente.Cognome = Console.ReadLine();
            Console.Write(" Inserisic la tua data di nascia");
            bool success = DateTime.TryParse(Console.ReadLine(),out DateTime data);
            //verifico il formato della data fino a quando
            //l'utente non inscerisce un valore corretto
            while (!success)
            {
                Console.WriteLine("Inserisci una data corretta");
                success = DateTime.TryParse(Console.ReadLine(), out DateTime date);
            }
            utente.DataNascita = data;           
        }
        public static void SchermoStampaDettagli()
        {
            if(bolletta.Utente == null)
            {

            }
            Console.WriteLine("Dati bolletta");
            Console.WriteLine(Program.bolletta.ToString());
        }
        #endregion
    }
}

