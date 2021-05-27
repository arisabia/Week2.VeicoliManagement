using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    enum UnitaMisura
    {
        Kmh,
        Mc,
        Min
    }
    enum TipoBolletta
    {
        Corrente,
        Gas,
        Telefono
    }
    class Bolletta
    {
        private static double ImportoBase = 40;
        private static double MoltiplicativoBase = 10;
        public double ConsumoTotale { get; set; } = 0.00;
        public DateTime DataScadenza { get; set; } = new DateTime(2000, 1, 1);
        private double Importo { get { return GetImporto(); } }
        public Utente Utente { get; set; } = new Utente();//per evitare che l'utente sia nulll
        //referimento classe Utente
        public TipoBolletta Tipologia{get; set;}
        //get e set per enum
       public UnitaMisura UM { get { return GetUnitaMisura(); } }
        //get e set per enum
        private double GetImporto()
        {
            return Bolletta.ImportoBase + (ConsumoTotale * Bolletta.MoltiplicativoBase);
        }
        private UnitaMisura GetUnitaMisura()
        {//collega unita di misura al tipo di bolletta
            if(Tipologia == TipoBolletta.Corrente)
            {
                return UnitaMisura.Kmh;
            }else if(Tipologia == TipoBolletta.Gas)
            {
                return UnitaMisura.Mc;
            }
            else
            {
                return UnitaMisura.Min;
            }
        }

        //private double CalcolaBolletta()
        //{//prova fatta da me
        //    double quotaFissa = 40;
        //    if (Importo == 0 )
        //    {
        //        return ConsumoTotale = quotaFissa;
        //    }
        //    else 
        //    {
        //        ConsumoTotale = quotaFissa + (Importo * 10);
        //    }
        //    return ConsumoTotale;

        //}

        public String ToString()
            {
                return $"Utenza: {Tipologia.ToString()}" +
                $"\n Data Scadenza {DataScadenza.ToShortDateString()}" +
                $"Per un consumo di {ConsumoTotale} {UM.ToString()}:" +
                $" {Importo} euto \n" +
                $"Da fatturare a : \n {Utente.ToString()}";
            }

    }
}
