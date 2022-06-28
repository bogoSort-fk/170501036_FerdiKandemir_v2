using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170501036_FerdiKandemir_v2
{
    public class Person
    {
        private string vorName, nachName, tcNummer, emailAdresse, telefonNummer, geschlecht, teamNummer;
        private int alter, benutzerID;

        public Person(string vorName, string nachName, string tcNummer, string telefonNummer, int benutzerID)
        {
            this.vorName = vorName;
            this.nachName = nachName;
            this.tcNummer = tcNummer;
            this.telefonNummer = telefonNummer;
            this.benutzerID = benutzerID;


        }

        public Person(string vorName, string nachName, string tcNummer, string emailAdresse, string telefonNummer, int benutzerID,string geschlecht, string teamNummer, int alter)
        {
            this.vorName = vorName;
            this.nachName = nachName;
            this.tcNummer = tcNummer;
            this.emailAdresse = emailAdresse;
            this.telefonNummer = telefonNummer;
            this.geschlecht = geschlecht;
            this.teamNummer = teamNummer;
            this.alter = alter;
        }

        public string VorName { get => vorName; set => vorName = value; }
        public string NachName { get => nachName; set => nachName = value; }
        public string TcNummer { get => tcNummer; set => tcNummer = value; }
        public string EmailAdresse { get => emailAdresse; set => emailAdresse = value; }
        public string TelefonNummer { get => telefonNummer; set => telefonNummer = value; }
        public string Geschlecht { get => geschlecht; set => geschlecht = value; }
        public string TeamNummer { get => teamNummer; set => teamNummer = value; }
        public int Alter { get => alter; set => alter = value; }
    }




}
