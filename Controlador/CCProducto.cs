using Entidad;
using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class CCProducto
    {
        public DataTable getListarProducto()
       {
           CDProducto ocdPro = new CDProducto();
           return ocdPro.getProductolistar();
       }
       public DataTable getProductoListDescripcion(string nombre)
       {
           CDProducto oCDProducto = new CDProducto();
           return oCDProducto.getProductoListDescripcion(nombre);

       }
       public DataTable getProductoListid(string nombre)
       {
           CDProducto oCDProducto = new CDProducto();
           return oCDProducto.getProductoListid(nombre);

       }
       public DataTable getProductoListDescp_id(string id, string nombre)
       {
           CDProducto oCDProducto = new CDProducto();
           return oCDProducto.getProductoListDescripcion_id(id, nombre);
       }
    }
    }

