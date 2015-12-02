using Entidad;
using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class CCClase
    {
        public static CEClase Clase_Consultar_datos(Result_transaccion obj_transac, string m_cod_clase)
        {
            CEClase obj_clase = new CEClase();
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                obj_clase = CDClase.Clase_Consultar_datos(conn, m_cod_clase);

                obj_transac.resultado = 1;
                obj_transac.msg_error = "";
            }
            catch (Exception ex)
            {
                obj_transac.resultado = 0;
                obj_transac.msg_error = "Error!!! No se pudo consultar los datos de la clase" + ex.Message;
            }
            finally
            {
                CDConnection.CloseConexion(conn);
            }

            return obj_clase;
        }
        public static void Clase_Grabar(string Accion, CEClase obj_clase, Result_transaccion obj_transac)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                if (Accion == "N")
                {
                    CDClase.Clase_Insertar(conn, obj_clase);
                }
                else
                {
                    CDClase.Clase_Actualizar(conn, obj_clase);
                }

                obj_transac.resultado = 1;
                obj_transac.new_codigo = obj_clase.cod_clase;
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
        public static void Clase_Eliminar(Result_transaccion obj_transac, string m_cod_clase)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDClase.Clase_Eliminar(conn, m_cod_clase);

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
        public DataTable getclaseAll()
        {
            CDClase oCDClase = new CDClase();
            return oCDClase.getClaseAll();
        }
    }
}
