using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ComposerInfo_WebApp.Models;

namespace ComposerInfo_WebApp.DAL
{
    public class MusicInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var composers = new List<Composer>
            {
                new Composer{FirstName="Wolfgang Amadeus", LastName="Mozart", BirthDate=DateTime.Parse("01/27/1756"), DeathDate=DateTime.Parse("12/05/1791") },
                new Composer{FirstName="Ludwig van", LastName="Beethoven", BirthDate=DateTime.Parse("12/16/1827"), DeathDate=DateTime.Parse("03/26/1827") },
                new Composer{FirstName="Gioacchino", LastName="Rossini", BirthDate=DateTime.Parse("02/29/1792"), DeathDate=DateTime.Parse("11/13/1868") },
                new Composer{FirstName="Richard", LastName="Wagner", BirthDate=DateTime.Parse("05/22/1813"), DeathDate=DateTime.Parse("02/13/1883") },
                new Composer{FirstName="Giuseppe", LastName="Verdi", BirthDate=DateTime.Parse("10/10/1813"), DeathDate=DateTime.Parse("01/27/1901") }
            };

            composers.ForEach(s => context.Composers.Add(s));
            context.SaveChanges();

            var operas = new List<Opera>
            {
                new Opera{Name="Le nozze di Figaro", Language="Italian", PremierDate=DateTime.Parse("05/01/1786")},
                new Opera{Name="Cosi fan tutte", Language="Italian", PremierDate=DateTime.Parse("01/26/1790")},
                new Opera{Name="Don Giovanni", Language="Italian", PremierDate=DateTime.Parse("10/29/1786")},
                new Opera{Name="Die Zauberflöte", Language="German", PremierDate=DateTime.Parse("09/30/1791")},
                new Opera{Name="Fidelio", Language="German", PremierDate=DateTime.Parse("11/20/1805")},
                new Opera{Name="Il barbiere di Siviglia", Language="Italian", PremierDate=DateTime.Parse("02/20/1816")},
                new Opera{Name="La Cenerentola", Language="Italian", PremierDate=DateTime.Parse("01/25/1817")},
                new Opera{Name="Lohengrin", Language="German", PremierDate=DateTime.Parse("08/28/1850")},
                new Opera{Name="Die Meistersinger von Nüremberg", Language="German", PremierDate=DateTime.Parse("11/02/1862")},
                new Opera{Name="Parsifal", Language="German", PremierDate=DateTime.Parse("07/26/1882")},
                new Opera{Name="Rigoletto", Language="Italian", PremierDate=DateTime.Parse("03/11/1851")},
                new Opera{Name="La Traviata", Language="Italian", PremierDate=DateTime.Parse("03/06/1853")},
                new Opera{Name="Aida", Language="Italian", PremierDate=DateTime.Parse("12/24/1871")},
            };
            operas.ForEach(s => context.Operas.Add(s));
            context.SaveChanges();
        }
    }
}