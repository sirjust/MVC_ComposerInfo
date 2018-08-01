using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComposerInfo_WebApp.Models
{
    public class Composer
    {
        public int ComposerID { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }

        public virtual ICollection<Opera> Operas { get; set; }
    }
}