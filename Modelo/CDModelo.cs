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
    public class CDModelo
    {
        public static CEModelo Modelo_Consultar_datos(SqlConnection conn,string m_cod_modelo)
        {
            CEModelo obj_modelo = new CEModelo();
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_modelo_detalle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_modelo", SqlDbType.Char, 3).Value = m_cod_modelo;
                    SqlDataReader dr_reesult = cmd.ExecuteReader();
                    if (dr_reesult.HasRows)
                    {
                        dr_reesult.Read();
                        obj_modelo.id_empresa = int.Parse(dr_reesult["id_empresa"].ToString());
                        obj_modelo.cod_modelo = dr_reesult["cod_modelo"].ToString();
                        obj_modelo.txt_abrv = dr_reesult["txt_abrv"].ToString();
                        obj_modelo.txt_desc = dr_reesult["txt_desc"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj_modelo;
        }
        public static void Modelo_Insertar(SqlConnection conn, CEModelo obj_modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_modelo_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_modelo.id_empresa;
                    cmd.Parameters.Add("@cod_modelo", SqlDbType.VarChar, 3).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_modelo.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_modelo.txt_desc;
                    cmd.ExecuteNonQuery();

                    obj_modelo.cod_modelo = cmd.Parameters["@cod_modelo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Modelo_Actualizar(SqlConnection conn, CEModelo obj_modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_modelo_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_modelo.id_empresa;
                    cmd.Parameters.Add("@cod_modelo", SqlDbType.VarChar, 3).Value = obj_modelo.cod_modelo;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_modelo.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_modelo.txt_desc;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Modelo_Eliminar(SqlConnection conn, string m_cod_modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_modelo_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_modelo", SqlDbType.VarChar, 3).Value = m_cod_modelo;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getModeloAll()
        {

            String procedure = "usp_modelo_Listar";
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
        public DataTable getModeloAnterior(string cod_marca)
        {

            String procedure = "usp_modelo_Listar_anterior";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add("@cod_marca", SqlDbType.VarChar, 3).Value = cod_marca;
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
