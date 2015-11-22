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
    public class CCModelo
    {
        public static CEModelo Modelo_Consultar_datos(Result_transaccion obj_transac, string m_cod_modelo)
        {
            CEModelo obj_modelo = new CEModelo();
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                obj_modelo = CDModelo.Modelo_Consultar_datos(conn, m_cod_modelo);

                obj_transac.resultado = 1;
                obj_transac.msg_error = "";
            }
            catch (Exception ex)
            {
                obj_transac.resultado = 0;
                obj_transac.msg_error = "Error!!! No se pudo consultar los datos del modelo" + ex.Message;
            }
            finally
            {
                CDConnection.CloseConexion(conn);
            }

            return obj_modelo;
        }
        public static void Modelo_Grabar(string Accion, CEModelo obj_modelo, Result_transaccion obj_transac)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                if (Accion == "N")
                {
                    CDModelo.Modelo_Insertar(conn, obj_modelo);
                }
                else
                {
                    CDModelo.Modelo_Actualizar(conn, obj_modelo);
                }

                obj_transac.resultado = 1;
                obj_transac.new_codigo = obj_modelo.cod_modelo;
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
        public static void Modelo_Eliminar(Result_transaccion obj_transac, string m_cod_modelo)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDModelo.Modelo_Eliminar(conn, m_cod_modelo);

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
        public DataTable getmodeloAll()
        {
            CDModelo oCDModelo = new CDModelo();
            return oCDModelo.getModeloAll();
        }
    }
}
