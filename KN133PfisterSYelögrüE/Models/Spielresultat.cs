using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KN133PfisterSYelögrüE.Models
{
    public class Spielresultat
    {
        public string id { get; set; }
        public string Heimteam { get; set; }
        public string Auswaertsteam { get; set; }
        public byte Heimtore { get; set; }
        public byte Auswaertstore { get; set; }
        public string Datum { get; set; }

        //Zum Darstellen der bereits gespielten Spiele (Für den User)
        public Spielresultat(string id, string Heimteam, string Auswaertsteam, byte Heimtore, byte Auswaertstore, string Datum)
        {
            this.id = id;
            this.Heimteam = Heimteam;
            this.Auswaertsteam = Auswaertsteam;
            this.Heimtore = Heimtore;
            this.Auswaertstore = Auswaertstore;
            this.Datum = Datum;
        }
        //Zum Darstellen der zukünftigen Spiele/der Dropdown-Liste zum Eingeben der Spielresultate
        public Spielresultat(string id, string Heimteam, string Auswaertsteam, string Datum)
        {
            this.id = id;
            this.Heimteam = Heimteam;
            this.Auswaertsteam = Auswaertsteam;
            this.Datum = Datum; 

        }
    }
}