using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComposerInfo_WebApp.Models
{
    public class Opera
    { 
        public int OperaID { get; set; }
        public int ComposerID { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public DateTime PremierDate { get; set; }
    }
}