using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CDClase
    {
        public static CEClase Clase_Consultar_datos(SqlConnection conn, string m_cod_clase)
        {
            CEClase obj_clase = new CEClase();
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_clase_detalle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_clase", SqlDbType.Char, 3).Value = m_cod_clase;
                    SqlDataReader dr_reesult = cmd.ExecuteReader();
                    if (dr_reesult.HasRows)
                    {
                        dr_reesult.Read();
                        obj_clase.id_empresa = int.Parse(dr_reesult["id_empresa"].ToString());
                        obj_clase.cod_cate = dr_reesult["cod_cate"].ToString();
                        obj_clase.cod_clase=dr_reesult["cod_clase"].ToString();
                        obj_clase.txt_abrv = dr_reesult["txt_abrv"].ToString();
                        obj_clase.txt_desc = dr_reesult["txt_desc"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj_clase;
        }
        public static void Clase_Insertar(SqlConnection conn, CEClase obj_clase)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_clase_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_clase.id_empresa;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar,3).Value = obj_clase.cod_cate;
                    cmd.Parameters.Add("@cod_clase", SqlDbType.VarChar, 3).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_clase.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_clase.txt_desc;
                    cmd.ExecuteNonQuery();

                    obj_clase.cod_clase = cmd.Parameters["@cod_clase"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Clase_Actualizar(SqlConnection conn, CEClase obj_clase)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_clase_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_clase.id_empresa;
                    cmd.Parameters.Add("@cod_cate", SqlDbType.VarChar, 3).Value = obj_clase.cod_cate;
                    cmd.Parameters.Add("@cod_clase",SqlDbType.VarChar,3).Value = obj_clase.cod_clase;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_clase.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_clase.txt_desc;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Clase_Eliminar(SqlConnection conn, string m_cod_clase)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_clase_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_clase", SqlDbType.VarChar, 3).Value = m_cod_clase;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getClaseAll()
        {

            String procedure = "usp_clase_Listar";
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
        public DataTable getClaseAnterior(string cod_cate)
        {

            String procedure = "usp_clase_Listar_anterior";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add("@cod_cate", SqlDbType.VarChar,3).Value = cod_cate;
                oSqlCommand.ExecuteNonQuery();
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
