using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CETipoProducto
    {
        public int id_empresa { get; set; }
        public string cod_cate { get; set; }
        public string cod_clase { get; set; }
        public string cod_tipo { get; set; }
        public string txt_abrv { get; set; }
        public string txt_desc { get; set; }

        public CETipoProducto()
        {
        }
    }
}
