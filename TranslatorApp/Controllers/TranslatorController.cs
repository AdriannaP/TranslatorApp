using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranslatorApp.Models;

namespace TranslatorApp.Controllers
{
    public class TranslatorController : Controller
    {
        
        public ActionResult Index()
        {
            using (var ctx = new DataContext())
            {
                var Lang = ctx.Translate.ToList();
                return View(Lang);
                
            }
        }           
        
        
        [HttpPost]
        public ActionResult Index(Translate translate)
        {
            using (var ctx = new DataContext())
            {
                ctx.Translate.Add(translate);
                ctx.SaveChanges();

                var languageList = ctx.Translate.ToList();
                return View(languageList);
            }
        }
    }
}