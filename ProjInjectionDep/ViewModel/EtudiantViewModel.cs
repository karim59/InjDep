using ProjInjectionDep.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjInjectionDep.ViewModel
{
    public class EtudiantViewModel:IEtudiant
    {
        public int Id { get { return 1; } set { } }
        public string Name { get; set; }
        public string Activite { get; set; }
    }
}