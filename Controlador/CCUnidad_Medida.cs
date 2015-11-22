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
    public class CCUnidad_Medida
    {
        public static CEUnidad_Medida Unidad_Medida_Consultar_datos(Result_transaccion obj_transac, string m_cod_um)
        {
            CEUnidad_Medida obj_um = new CEUnidad_Medida();
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                obj_um = CDUnidad_Medida.Unidad_Medida_Consultar_datos(conn,m_cod_um);

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

            return obj_um;
        }
        public static void Unidad_Medida_Grabar(string Accion, CEUnidad_Medida obj_um, Result_transaccion obj_transac)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                if (Accion == "N")
                {
                    CDUnidad_Medida.Unidad_Medida_Insertar(conn,obj_um);
                }
                else
                {
                    CDUnidad_Medida.Unidad_Medida_Actualizar(conn, obj_um);
                }

                obj_transac.resultado = 1;
                obj_transac.new_codigo = obj_um.cod_um;
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
        public static void Unidad_Medida_Eliminar(Result_transaccion obj_transac, string m_cod_um)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDUnidad_Medida.Unidad_Medida_Eliminar(conn, m_cod_um);

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
        public DataTable getunidadMedidaAll()
        {
            CDUnidad_Medida oCDUnidad = new CDUnidad_Medida();
            return oCDUnidad.getUnidadMedidaAll();
        }
    }
}
