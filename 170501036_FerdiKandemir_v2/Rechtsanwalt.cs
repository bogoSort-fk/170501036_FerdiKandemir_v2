using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170501036_FerdiKandemir_v2
{
    public class Rechtsanwalt : Person
    {
        public Rechtsanwalt(string vorName, string nachName, string tcNummer, string telefonNummer, int benutzerID) : base(vorName, nachName, tcNummer, telefonNummer, benutzerID)
        {

        }
        public Rechtsanwalt(string vorName, string nachName, string tcNummer, string emailAdresse, string telefonNummer, int benutzerID, string geschlecht, string teamNummer, int alter) : base(vorName, nachName, tcNummer, emailAdresse, telefonNummer, benutzerID, geschlecht, teamNummer, alter)
        {

        }

     


    }
}
