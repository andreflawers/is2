using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class CDCategoria
    {
        public static CECategoria Categoria_Consultar_datos(SqlConnection conn, string m_cod_cate)
        {
            CECategoria obj_cate = new CECategoria();
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_categoria_detalle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.Char, 3).Value = m_cod_cate;
                    SqlDataReader dr_reesult = cmd.ExecuteReader();
                    if (dr_reesult.HasRows)
                    {
                        dr_reesult.Read();
                        obj_cate.id_empresa = int.Parse(dr_reesult["id_empresa"].ToString());
                        obj_cate.cod_cate = dr_reesult["cod_cate"].ToString();
                        obj_cate.txt_abrv = dr_reesult["txt_abrv"].ToString();
                        obj_cate.txt_desc = dr_reesult["txt_desc"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj_cate;
        }
        public static void Categoria_Insertar(SqlConnection conn, CECategoria obj_cate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_categoria_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_cate.id_empresa;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar, 3).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_cate.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_cate.txt_desc;
                    cmd.ExecuteNonQuery();

                    obj_cate.cod_cate = cmd.Parameters["@cod_cate"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Categoria_Actualizar(SqlConnection conn, CECategoria obj_cate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_categoria_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_cate.id_empresa;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar, 3).Value = obj_cate.cod_cate;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_cate.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_cate.txt_desc;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Categoria_Eliminar(SqlConnection conn, string m_cod_cate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_categoria_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar, 3).Value = m_cod_cate;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getCategoriaAll()
        {

            String procedure = "usp_categoria_Listar";
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
