using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class CDProducto
    {
        public static CEProducto Producto_Consultar_datos(SqlConnection conn, string m_id_producto)
        {
            CEProducto obj_prod = new CEProducto();
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_producto_detalle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_producto", SqlDbType.BigInt).Value = m_id_producto;
                    SqlDataReader dr_reesult = cmd.ExecuteReader();
                    if (dr_reesult.HasRows)
                    {
                        dr_reesult.Read();
                        obj_prod.cod_cate = dr_reesult["cod_cate"].ToString();
                        obj_prod.cod_clase = dr_reesult["cod_clase"].ToString();
                        obj_prod.cod_tipo = dr_reesult["cod_tipo"].ToString();
                        obj_prod.cod_marca = dr_reesult["cod_marca"].ToString();
                        obj_prod.cod_modelo = dr_reesult["cod_modelo"].ToString();
                        obj_prod.cod_um_principal = dr_reesult["cod_um_principal"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj_prod;
        }
        public static void Producto_Insertar(SqlConnection conn, CEProducto obj_prod)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_producto_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar,3).Value = obj_prod.cod_cate;
                    cmd.Parameters.Add("@cod_clase", SqlDbType.VarChar, 3).Value = obj_prod.cod_clase;
                    cmd.Parameters.Add("@cod_tipo", SqlDbType.VarChar, 4).Value = obj_prod.cod_tipo;
                    cmd.Parameters.Add("@cod_marca", SqlDbType.VarChar, 3).Value = obj_prod.cod_marca;
                    cmd.Parameters.Add("@cod_modelo", SqlDbType.VarChar, 3).Value = obj_prod.cod_modelo;
                    cmd.Parameters.Add("@cod_um_principal", SqlDbType.VarChar, 3).Value = obj_prod.cod_um_principal;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Producto_Actualizar(SqlConnection conn, CEProducto obj_prod)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_producto_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_producto", SqlDbType.BigInt).Value = obj_prod.id_producto;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar, 3).Value = obj_prod.cod_cate;
                    cmd.Parameters.Add("@cod_clase", SqlDbType.VarChar, 3).Value = obj_prod.cod_clase;
                    cmd.Parameters.Add("@cod_tipo", SqlDbType.VarChar, 4).Value = obj_prod.cod_tipo;
                    cmd.Parameters.Add("@cod_marca", SqlDbType.VarChar, 3).Value = obj_prod.cod_marca;
                    cmd.Parameters.Add("@cod_modelo", SqlDbType.VarChar, 3).Value = obj_prod.cod_modelo;
                    cmd.Parameters.Add("@cod_um_principal", SqlDbType.VarChar, 3).Value = obj_prod.cod_um_principal;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Producto_Eliminar(SqlConnection conn, string m_id_producto)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_producto_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_producto", SqlDbType.BigInt).Value = m_id_producto;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getProductoAll()
        {

            String procedure = "usp_producto_Listar";
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
