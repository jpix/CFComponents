using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFComponentN18
{

   
    sealed public class CFDataMembers: ICFDataMembers
    {

        public string Cognome { get ; set ; }
        public string Nome { get ; set ; }
        public string Sesso { get; set; }
        public DateTime DataDiNascita { get ; set ; }
        public string RegioneDiNascita { get ; set; }
        public string ProvinciaDiNascita { get ; set ; }
        public string ComuneDiNascita { get ; set ; }
        public string CodiceISTATComune { get ; set ; }
        public string TargaAutomobilistica { get; set; }


        //default ctor
        public CFDataMembers()
        {

            Cognome = String.Empty;
            Nome = String.Empty;
            Sesso = String.Empty;
            RegioneDiNascita = String.Empty;
            ProvinciaDiNascita = String.Empty;
            ComuneDiNascita = String.Empty;
            CodiceISTATComune = String.Empty;
            DataDiNascita = DateTime.Now;
            TargaAutomobilistica = String.Empty;



        }
    }
}
