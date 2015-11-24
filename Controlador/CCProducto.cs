using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidad;
using System.Data;

namespace Controlador
{
    public class CCProducto
    {
        public DataTable getProductoList()
        {
            CDProducto oCDProducto = new CDProducto();
            return oCDProducto.getProductoList();
        
        }

        public int productoCreate(CEProducto oCEProducto)
        {
            CDProducto oCDProducto = new CDProducto();
            return oCDProducto.productoCreate(oCEProducto);
        }
    }
}
