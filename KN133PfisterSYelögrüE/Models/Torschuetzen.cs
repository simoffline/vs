using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KN133PfisterSYelögrüE.Models
{
    public class Torschuetzen
    {
        public string Name { get; set; }
        public int AnzTore { get; set; }
        public Torschuetzen(string Name, int AnzTore)
        {
            this.Name = Name;
            this.AnzTore = AnzTore;
            
        }

    }

}