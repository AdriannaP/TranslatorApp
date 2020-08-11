using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TranslatorApp.Models
{
   // [Table("TranslatorApp")]
    public class Translate 
    {
        [Key]
        public int Id { get; set; }
        public string PolishLanguage { get; set; }
        public string GermanLanguage { get; set; }
    }

       
}