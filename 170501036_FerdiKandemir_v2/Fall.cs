using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170501036_FerdiKandemir_v2 { 
internal class Fall
{
    private string fallNummer, fallName, fallDesc, fallType, beklagterVorname, beklagterNachname;

    public Fall(string fallNummer, string fallName, string fallDesc, string fallType, string beklagterVorname, string beklagterNachname)
    {
        this.fallNummer = fallNummer;
        this.fallName = fallName;
        this.fallDesc = fallDesc;
        this.fallType = fallType;
        this.beklagterVorname = beklagterVorname;
        this.beklagterNachname = beklagterNachname;
    }

    public string FallNummer { get => fallNummer; set => fallNummer = value; }
    public string FallName { get => fallName; set => fallName = value; }
    public string FallDesc { get => fallDesc; set => fallDesc = value; }
    public string FallType { get => fallType; set => fallType = value; }
    public string BeklagterVorname { get => beklagterVorname; set => beklagterVorname = value; }
    public string BeklagterNachname { get => beklagterNachname; set => beklagterNachname = value; }
}
}