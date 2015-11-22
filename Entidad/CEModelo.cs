using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class CEModelo
    {
        public int id_empresa { get; set; }
        public string cod_modelo { get; set; }
        public string txt_abrv { get; set; }
        public string txt_desc { get; set; }

        public CEModelo()
        {
        }
    }
}
