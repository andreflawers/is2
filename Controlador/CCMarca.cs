using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class CCMarca
    {
        public DataTable getMarcaAll()
        {
            CDMarca oCDMarca = new CDMarca();
            return oCDMarca.getMarcaAll();
        }
    }
}
