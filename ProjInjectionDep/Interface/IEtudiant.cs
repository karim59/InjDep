using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjInjectionDep.Interface
{
    public interface IEtudiant
    {
        int Id { get; set; }
        string Name { get; set; }
        string Activite { get; set; }
    }
}
