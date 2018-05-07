using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFComponentN18
{
    public interface ICFDataMembers
    {
        string Cognome { get; set; }
        string Nome { get; set; }
        DateTime DataDiNascita { get; set; }
        string RegioneDiNascita { get; set; }
        string ProvinciaDiNascita { get; set; }
        string ComuneDiNascita { get; set; }
        string CodiceISTATComune { get; set; }
         
    }
}