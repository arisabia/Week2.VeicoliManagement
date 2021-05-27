using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    public static class GestioneIO
    {
        //Crezione Directory
        public static void CreazioneDirectory(string dirName)
        {//creo il path della cartella e creo una cartella nuova
            string path = Path.Combine(Environment.GetFolderPath
                    (Environment.SpecialFolder.MyPictures),
                dirName);//nelle "" al posto di dirName se prestabilisco io il nome della cartella
            
            DirectoryInfo directory = new DirectoryInfo(path);
            
            try
            {
                directory.Create();
               // Directory.CreateDirectory(path);
                Console.WriteLine("La cartella è stata creata corretamente");
            }
            catch (IOException e)//input output exception
            {
                Console.WriteLine(e.Message);
            }
           

        }

        public static void EliminaCartella(string dirName)
        {
            //richiamo il percorso della cartella 'Imagini'
            // string path ="C:\\Desktop\\Picture" e la stessa cosa di fare cosi
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                dirName);
            DirectoryInfo dir = new DirectoryInfo(path);


            try
            {
                //cancella la cartella
                dir.Delete();
                //Directory.Delete(path);
                Console.WriteLine("cartella eliminata correttamente");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);//stapo messaggio di errore
            }
        }
        public static void SpostaCartella()
        {
            string pathSource = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                "EsempioSpostamentoCartella");
            string pathDest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
                , "EsempioSpostamentoCartella");
           


            try
            {
                Directory.CreateDirectory(pathSource);
                Console.WriteLine("Cartella creata correttamente");
                Console.ReadLine();// per interropere l'esecuzione
                Directory.Move(pathSource, pathDest);
                Console.WriteLine("Cartella spostata con successo");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void StampaContenutoCartella()
        {
            DirectoryInfo[] directories = new DirectoryInfo(Environment
               .GetFolderPath(Environment.SpecialFolder.MyVideos))
               .GetDirectories();
            Console.WriteLine("contenuto della cartella video");
            foreach(var dir in directories)
            {
                
                Console.WriteLine($"\t {dir.Name}");
            }
            Console.ReadLine();
        }

        public static void ScritturaFile(Persona p)
        {
            string filePath = Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.MyMusic), "testo.txt");
            StreamWriter file = null;
            try
            {

                using (file = File.CreateText(filePath))
                    //sovrascrive il file se este altrimeti lo crea e poi ci scrive sopra
                {
                    file.WriteLineAsync("questa è la prima stampa su file");
                    file.WriteAsync(p.ToString());//WriteAsync non va a capo
                    file.WriteLineAsync(p.ToString());
                }//dopo la creazione il file viene liberato
                 //dalla parolla using
                Console.WriteLine("stampa eseguita con successo");
            }catch(Exception e)//eccezione generica
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                file.Close();//chiusura del flusso verso il file
            }//si puo omettere perche usiamo using
            //perche using chiama il garbage colector e fa la chiusura
            //ma e meglio utilizzarla
        }
        public static void LeggiDaFile()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
                , "testo.txt");
            string line;//tiene la tracia della linie nel file di testo
            Persona p = new Persona();
            try { 

                 using(StreamReader reader = File.OpenText(path))
            {
                while((line = reader.ReadLine())!= null)//richiedo la lettura della singola linea
                {
                        string[] values = line.Split(",");//per fare lo split del testo al interno del file creato
                        
                        p.Nome = values[0];
                        p.Cognome = values[1];
                        p.Eta = Convert.ToInt32(values[2]);
                        p.DataNascita = Convert.ToDateTime(values[3]);
                        Console.WriteLine(line);
                }
          }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static ArrayList CaricaPersoneDaFile()
        {
            ArrayList persone = new ArrayList();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
                , "testo.txt");
            string line;
            try
            {
                using (StreamReader fileReader = File.OpenText(path))
                {
                    //leggo a fino a quando trovo contenuto nel file
                    while((line = fileReader.ReadLine()) != null)//fineche la tettura e diversa da null
                    {
                        string[] valoriPersona = line.Split(";");
                        string nome = valoriPersona[0];
                        string cognome = valoriPersona[1];
                        int eta = Convert.ToInt32(valoriPersona[2]);
                        DateTime DataNascita = Convert.ToDateTime(valoriPersona[3]);
                        Persona p = new Persona()
                        {
                            Nome = nome,
                            Cognome = cognome,
                            Eta = eta,
                            DataNascita = DataNascita
                        };
                        persone.Add(p);
                        //leggo un intera lista di elementi
                        //ottengo la persistenza del codice,se chiudo il programa i dati rimangono salvati
                        //con il file system i mei ogg rimangono persistenti
                    }
                }//qui richiamiamo l'azione del garbage collector
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return persone;
        }
        public static void StampaPersoneSuFile(ArrayList persone)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "persone.txt");//se vine trovata il file scrive al interno se no lo crea
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    //foreach(Persona pers in persone)
                    foreach(var objPersona in persone)//ciclo la lista
                    {
                        Persona persona = (Persona)objPersona;//cast da Object a Persona
                        writer.WriteLineAsync($"{persona.Nome};{persona.Cognome};{persona.Eta};{persona.DataNascita.ToShortDateString()}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
