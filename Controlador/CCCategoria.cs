using Entidad;
using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
   public class CCCategoria
    {
        public static CECategoria Categoria_Consultar_datos(Result_transaccion obj_transac, string m_cod_cate)
        {
            CECategoria obj_cate = new CECategoria();
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                obj_cate = CDCategoria.Categoria_Consultar_datos(conn, m_cod_cate);

                obj_transac.resultado = 1;
                obj_transac.msg_error = "";
            }
            catch (Exception ex)
            {
                obj_transac.resultado = 0;
                obj_transac.msg_error = "Error!!! No se pudo consultar los datos de la categoria" + ex.Message;
            }
            finally
            {
                CDConnection.CloseConexion(conn);
            }

            return obj_cate;
        }
        public static void Categoria_Grabar(string Accion, CECategoria obj_cate, Result_transaccion obj_transac)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                if (Accion == "N")
                {
                    CDCategoria.Categoria_Insertar(conn, obj_cate);
                }
                else
                {
                    CDCategoria.Categoria_Actualizar(conn, obj_cate);
                }

                obj_transac.resultado = 1;
                obj_transac.new_codigo = obj_cate.cod_cate;
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
        public static void Categoria_Eliminar(Result_transaccion obj_transac, string m_cod_cate)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDCategoria.Categoria_Eliminar(conn, m_cod_cate);

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
        public DataTable getcategoriaAll()
        {
            CDCategoria oCDCategoria = new CDCategoria();
            return oCDCategoria.getCategoriaAll();
        }
    }
}
