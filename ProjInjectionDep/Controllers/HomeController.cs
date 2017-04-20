using ProjInjectionDep.Interface;
using ProjInjectionDep.Models;
using ProjInjectionDep.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjInjectionDep.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEtudiant etudiant;

        // constructor
        public HomeController(IEtudiant etudiant)
        {
            this.etudiant = etudiant;
        }
        public ActionResult Index()
        {
            EtudiantViewModel _Etudiant = new EtudiantViewModel();
            _Etudiant.Name = "Karim";
            ViewBag.Message = _Etudiant.Name;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}