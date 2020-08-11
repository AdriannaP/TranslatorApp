using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TranslatorApp.Models
{
    public class DataContext : DbContext

    {
        public DataContext(): base("name=TranslatorApp")
        {

        }
        public DbSet<Translate> Translate { get; set; }
    }
}