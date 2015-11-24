using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CEProducto
    {
        public int id_Producto {get;set;}
        public string descripción_Producto {get;set;}
        public int  cantidad_Producto{get;set;}
        public double precio_Producto {get;set; }
        public string Id_SubFamilia {get;set;}
        public string id_marca{get;set;}
        public string id_Presentacion { get; set; }

        
    }
}
