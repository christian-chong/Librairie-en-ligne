using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Models;

namespace IHMWeb.Controllers
{
    public class LivreController : Controller
    {
        private DAL.Dao dao;
        
        // GET: Livre
        [HttpGet]
        public ActionResult Liste()
        {
            dao = new Dao();
            var livres = dao.AllLivres();
            return View(livres);
        }
    }
}