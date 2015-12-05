using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using Entidad;

namespace Controlador
{
    public class CCInventario
    {
        public DataTable getInvAll()
        {
            CDinventario oCDinventario = new CDinventario();
            return oCDinventario.getAllProducts();
        }
        public DataTable getInventarioList()
        {
            CDinventario oCDinventario = new CDinventario();
            return oCDinventario.getInventarioList();

        }
        public DataTable getAlmacenList()
        {
            CDinventario oCDinventario = new CDinventario();
            return oCDinventario.getAlmacenList();

        }

        public DataTable getinventarioGriewList(CEInventario oEntidad)
        {
            CDinventario oCDinventario = new CDinventario();
            return oCDinventario.getGriewList(oEntidad);

        }
        
    }
}
