using ProjInjectionDep.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjInjectionDep.ViewModel;
using ProjInjectionDep.Models;
using AutoMapper;

namespace ProjInjectionDep.Services
{
    public class EtudiantService : IEtudiantService
    {
        private EcoleEntities db = new EcoleEntities();
        public List<EtudiantViewModel> GetAllEtudiant()
        {
            List<Etudiant> listEtudiant = new List<Etudiant>();
            listEtudiant = db.Etudiant.ToList();
            List<EtudiantViewModel> listEtudiantViewModel = new List<EtudiantViewModel>();
            listEtudiantViewModel = Mapper.Map<List<Etudiant>, List<EtudiantViewModel>>(listEtudiant);

            return listEtudiantViewModel;

        }

        public EtudiantViewModel GetEtudiant(int id)
        {
            throw new NotImplementedException();
        }

        public int GetDouble(int a)
        {
            return a * 2;
        }
    }
}