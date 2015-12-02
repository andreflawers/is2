using Entidad;
using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class CCProducto
    {
        public static CEProducto Producto_Consultar_datos(Result_transaccion obj_transac, string m_id_producto)
        {
            CEProducto obj_prod = new CEProducto();
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                obj_prod = CDProducto.Producto_Consultar_datos(conn, m_id_producto);

                obj_transac.resultado = 1;
                obj_transac.msg_error = "";
            }
            catch (Exception ex)
            {
                obj_transac.resultado = 0;
                obj_transac.msg_error = "Error!!! No se pudo consultar los datos del producto" + ex.Message;
            }
            finally
            {
                CDConnection.CloseConexion(conn);
            }

            return obj_prod;
        }
        public static void Producto_Grabar(string Accion, CEProducto obj_prod, Result_transaccion obj_transac)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                if (Accion == "N")
                {
                    CDProducto.Producto_Insertar(conn, obj_prod);
                }
                else
                {
                    CDProducto.Producto_Actualizar(conn, obj_prod);
                }

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
        public static void Producto_Eliminar(Result_transaccion obj_transac, string m_id_producto)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDProducto.Producto_Eliminar(conn, m_id_producto);

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
        public DataTable getproductoAll()
        {
            CDProducto oCDProducto = new CDProducto();
            return oCDProducto.getProductoAll();
        }
    }
}
