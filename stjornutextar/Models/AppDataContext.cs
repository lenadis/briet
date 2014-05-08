using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace stjornutextar.Models
{
    public class AppDataContext : DbContext
    { 
        //allar toflur sem databaseinn a ad geta nad/skrifad i fara her
        //allir model klasar
        public DbSet<Subtitle> Subtitles { get; set; }
    }
}