using Castle.Core.Internal;
using Moq;
using ProjInjectionDep.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInjectionDep.Interface
{
   public interface IEtudiantService
    {
        EtudiantViewModel GetEtudiant(int id);
        List<EtudiantViewModel> GetAllEtudiant();
        int GetDouble(int id);
    }

}

