using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CEMarca
    {
        public int id_empresa{get;set;}
        public string cod_iso_idio_orgn { get; set; }
        public string cod_marca { get; set; }
        public string txt_abrv { get; set; }
        public string txt_desc { get; set; }

        public CEMarca()
        {
        }
        public CEMarca(int m_id,string m_cod_iso, string m_cod,string m_abrv,string m_desc)
        {
            this.id_empresa = m_id;
            this.cod_iso_idio_orgn = m_cod_iso;
            this.cod_marca = m_cod;
            this.txt_abrv = m_abrv;
            this.txt_desc = m_desc;
 
        }
    }
}
