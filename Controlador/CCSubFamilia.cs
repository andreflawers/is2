using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class CCSubFamilia
    {
        public DataTable getSubFamiliaAll()
        {
            CDSubFamilia oCDSubFamilia = new CDSubFamilia();
            return oCDSubFamilia.getSubFamiliaAll();
        }
    }
}
