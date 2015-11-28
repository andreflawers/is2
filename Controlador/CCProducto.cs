using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class CCProducto
    {
       public DataTable getListarProducto()
       {
           CDProducto ocdPro = new CDProducto();
           return ocdPro.getProductolistar();
       }
    }
}
