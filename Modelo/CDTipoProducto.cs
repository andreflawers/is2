using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class CDTipoProducto
    {
        public static CETipoProducto Tipo_Producto_Consultar_datos(SqlConnection conn, string m_cod_tipo)
        {
            CETipoProducto obj_tipo = new CETipoProducto();
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_tipo_producto_detalle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_tipo", SqlDbType.Char, 4).Value = m_cod_tipo;
                    SqlDataReader dr_reesult = cmd.ExecuteReader();
                    if (dr_reesult.HasRows)
                    {
                        dr_reesult.Read();
                        obj_tipo.id_empresa = int.Parse(dr_reesult["id_empresa"].ToString());
                        obj_tipo.cod_cate = dr_reesult["cod_cate"].ToString();
                        obj_tipo.cod_clase = dr_reesult["cod_clase"].ToString();
                        obj_tipo.cod_tipo=dr_reesult["cod_tipo"].ToString();
                        obj_tipo.txt_abrv = dr_reesult["txt_abrv"].ToString();
                        obj_tipo.txt_desc = dr_reesult["txt_desc"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj_tipo;
        }
        public static void Tipo_Producto_Insertar(SqlConnection conn, CETipoProducto obj_tipo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_tipo_producto_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_tipo.id_empresa;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar, 3).Value = obj_tipo.cod_cate;
                    cmd.Parameters.Add("@cod_clase", SqlDbType.VarChar, 3).Value = obj_tipo.cod_clase;
                    cmd.Parameters.Add("@cod_tipo", SqlDbType.VarChar, 4).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_tipo.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_tipo.txt_desc;
                    cmd.ExecuteNonQuery();

                    obj_tipo.cod_tipo = cmd.Parameters["@cod_tipo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Tipo_Producto_Actualizar(SqlConnection conn, CETipoProducto obj_tipo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_tipo_producto_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_tipo.id_empresa;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar, 3).Value = obj_tipo.cod_cate;
                    cmd.Parameters.Add("@cod_clase", SqlDbType.VarChar, 3).Value = obj_tipo.cod_clase;
                    cmd.Parameters.Add("@cod_tipo", SqlDbType.VarChar, 4).Value = obj_tipo.cod_tipo;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_tipo.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_tipo.txt_desc;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Tipo_Producto_Eliminar(SqlConnection conn, string m_cod_tipo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_tipo_producto_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_tipo", SqlDbType.VarChar, 4).Value = m_cod_tipo;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getTipoProductoAll()
        {

            String procedure = "usp_tipo_producto_Listar";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
                SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                DataTable oDataTable = new DataTable();
                oSqlDataAdapter.Fill(oDataTable);
                return oDataTable;

            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
        }
    }
}
