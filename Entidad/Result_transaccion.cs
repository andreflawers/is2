using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public  class Result_transaccion
    {
        public int resultado { get; set; }
        public string msg_error { get; set; }
        public string new_codigo { get; set; }
        public int new_cod { get; set; }

        public Result_transaccion()
        {
        }
    }
}
