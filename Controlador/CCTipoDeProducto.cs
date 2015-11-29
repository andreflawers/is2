using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class CCTipoDeProducto
    {
        public DataTable listartipoproducto()
        {
            CDTipoDeProducto ocdtipo = new CDTipoDeProducto();
            return ocdtipo.getTipoProductolistar();
        }
        public DataTable getllenarcombo()
        {
            CDTipoDeProducto ocdtipo = new CDTipoDeProducto();
            return ocdtipo.llenar_combobox();
        }
        public DataTable getllenarcombo2()
        {
            CDTipoDeProducto osub = new CDTipoDeProducto();
            return osub.llenar_combobox2();
        }
        public DataTable getllenarcombo3()
        {
            CDTipoDeProducto osub = new CDTipoDeProducto();
            return osub.llenar_combobox3();
        }
        public DataTable getllenarcombo4()
        {
            CDTipoDeProducto osub = new CDTipoDeProducto();
            return osub.llenar_combobox4();
        }
        public DataTable geteliminar(string cod_tipo)
        {
            CDTipoDeProducto OCD = new CDTipoDeProducto();
            return OCD.gettipoproducto_eliminar(cod_tipo);
        }
        public bool getinsertartipo(Entidad.CETipoDeProducto otipo)
        {
            CDTipoDeProducto ocd = new CDTipoDeProducto();
            return ocd.getTipoProducto_insertar(otipo);
        }
        public bool getactualizartipoproducto(Entidad.CETipoDeProducto otipoproducto)
        {
            CDTipoDeProducto ocd = new CDTipoDeProducto();
            return ocd.actualizartipoproducto(otipoproducto);
        }
    }
}
