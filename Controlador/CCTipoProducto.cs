using Entidad;
using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class CCTipoProducto
    {
        public static CETipoProducto Tipo_Producto_Consultar_datos(Result_transaccion obj_transac, string m_cod_tipo)
        {
            CETipoProducto obj_tipo = new CETipoProducto();
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                obj_tipo = CDTipoProducto.Tipo_Producto_Consultar_datos(conn, m_cod_tipo);

                obj_transac.resultado = 1;
                obj_transac.msg_error = "";
            }
            catch (Exception ex)
            {
                obj_transac.resultado = 0;
                obj_transac.msg_error = "Error!!! No se pudo consultar los datos del tipo de producto" + ex.Message;
            }
            finally
            {
                CDConnection.CloseConexion(conn);
            }

            return obj_tipo;
        }
        public static void Tipo_Producto_Grabar(string Accion, CETipoProducto obj_tipo, Result_transaccion obj_transac)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                if (Accion == "N")
                {
                    CDTipoProducto.Tipo_Producto_Insertar(conn, obj_tipo);
                }
                else
                {
                    CDTipoProducto.Tipo_Producto_Actualizar(conn, obj_tipo);
                }

                obj_transac.resultado = 1;
                obj_transac.new_codigo = obj_tipo.cod_tipo;
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
        public static void Tipo_Producto_Eliminar(Result_transaccion obj_transac, string m_cod_tipo)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDTipoProducto.Tipo_Producto_Eliminar(conn, m_cod_tipo);

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
        public DataTable gettipoProductoAll()
        {
            CDTipoProducto oCDTipoProducto = new CDTipoProducto();
            return oCDTipoProducto.getTipoProductoAll();
        }
        public DataTable gettpAnterior(string cod_cate,string cod_clase)
        {
            CDTipoProducto oCDTP = new CDTipoProducto();
            return oCDTP.getTPAnterior(cod_cate,cod_clase);

        }
    }
}
