using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170501036_FerdiKandemir_v2

{
    internal class TeamLead : Person
    {
        public TeamLead(string vorName, string nachName, string tcNummer, string telefonNummer) : base(vorName, nachName, tcNummer, telefonNummer)
        {

        }
        public TeamLead(string vorName, string nachName, string tcNummer, string emailAdresse, string telefonNummer, string geschlecht, string teamNummer, int alter) : base(vorName, nachName, tcNummer, emailAdresse, telefonNummer, geschlecht, teamNummer, alter)
        {

        }

    }
}