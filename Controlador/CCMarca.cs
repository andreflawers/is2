using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class CCMarca
    {
        public static CEMarca Marca_Consultar_datos(Result_transaccion obj_transac, string m_cod_marca)
        {
            CEMarca obj_marca = new CEMarca();
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                obj_marca = CDMarca.Marca_Consultar_datos(conn,m_cod_marca);

                obj_transac.resultado = 1;
                obj_transac.msg_error = "";
            }
            catch (Exception ex)
            {
                obj_transac.resultado = 0;
                obj_transac.msg_error = "Error!!! No se pudo consultar los datos de la marca" + ex.Message;
            }
            finally
            {
                CDConnection.CloseConexion(conn);
            }

            return obj_marca;
        }

        public static void Marca_Grabar(string Accion, CEMarca obj_marca, Result_transaccion obj_transac)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                if (Accion == "N")
                {
                    CDMarca.Marca_Insertar(conn,obj_marca);
                }
                else
                {
                    CDMarca.Marca_Actualizar(conn,obj_marca);
                }

                obj_transac.resultado = 1;
                obj_transac.new_codigo = obj_marca.cod_marca;
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

        public static void Marca_Eliminar(Result_transaccion obj_transac, string m_cod_marca)
        {
            SqlConnection conn = null;

            try
            {
                conn = new CDConnection().openDB();
                CDMarca.Marca_Eliminar(conn,m_cod_marca);

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
        public DataTable getMarcaAll()
        {
            CDMarca oCDMarca = new CDMarca();
            return oCDMarca.getMarcaAll();
        }
    }
}
