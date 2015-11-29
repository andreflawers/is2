using Entidad;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class CCFamilia
    {
        public DataTable getFamiliaAlista()
        {
            CDFamilia oCDFamilia = new CDFamilia();
            return oCDFamilia.getFamilialistar();
        }
        public DataTable getbuscar_familia(string Nombre)
        {
            CDFamilia ocdc = new CDFamilia();
            return ocdc.Buscar(Nombre);
        }
        public bool insertar_familia(CEFamilia ofamilia)
        {
            CDFamilia ocd = new CDFamilia();
             return ocd.getFamilia_insertar(ofamilia);
        }
        //public void getFamiliainsertar(Entidad.Familia oFamilia)
        //{
          //  CDFamilia oCDFamilia = new CDFamilia();
           // return oCDFamilia.Insertar(oFamilia);
        //}
        public bool getfamiliaactualiza(Entidad.CEFamilia ofamilia)
        {
            CDFamilia ocd = new CDFamilia();
            return ocd.getFamilia_actualizar(ofamilia);
        }
        public DataTable getfamiliaeliminar(string Id_Familia)
        {
            CDFamilia oCD = new CDFamilia();
            return oCD.getFammilia_eliminar(Id_Familia);
        }
    }
}
