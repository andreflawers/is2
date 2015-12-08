using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CEProducto
    {
        public int id_producto { get; set; }
        public string cod_cate { get; set; }
        public string cod_clase { get; set; }
        public string cod_tipo { get; set; }
        public string cod_marca { get; set; }
        public string cod_modelo { get; set; }
        public string cod_um_principal { get; set; }

        public CEProducto()
        {
        }
    }
}
