using Entidad;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class CCMarca_Modelo
    {
        public static void Marca_Modelo_Eliminar(Result_transaccion obj_transac, string m_cod_marca)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDMarca_Modelo.Marca_Modelo_Eliminar(conn, m_cod_marca);

                obj_transac.resultado = 1;
                obj_transac.msg_error = "";
            }
            catch (Exception ex)
            {
                obj_transac.resultado = 0;
                obj_transac.msg_error = "Error!!! No se pudo eliminar la informacion de la base de datos" + ex.Message;
            }
            finally
            {
                CDConnection.CloseConexion(conn);
            }
        }
        public DataTable getMarcaModeloAll()
        {
            CDMarca_Modelo oCDMarca_Modelo = new CDMarca_Modelo();
            return oCDMarca_Modelo.getMarca_ModeloAll();
        }
        public static void Marca_Modelo_Grabar(CEMarca_Modelo obj_marca_modelo, Result_transaccion obj_transac)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDMarca_Modelo.Marca_Modelo_Insertar(conn,obj_marca_modelo);
                obj_transac.resultado = 1;
                obj_transac.msg_error = "";
            }
            catch (Exception ex)
            {
                obj_transac.resultado = 0;
                obj_transac.msg_error = "Error!!! No se pudo grabar la informacion en la base de datos" + ex.Message;
            }
            finally
            {
                CDConnection.CloseConexion(conn);
            }
        }
    }
}
