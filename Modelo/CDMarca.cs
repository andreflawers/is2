using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Modelo
{
    public class CDMarca
    {
        public static CEMarca Marca_Consultar_datos(SqlConnection conn, string m_cod_marca)
        {
            CEMarca obj_marca = new CEMarca();
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_marca_detalle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_marca", SqlDbType.Char, 3).Value = m_cod_marca;
                    SqlDataReader dr_reesult = cmd.ExecuteReader();
                    if (dr_reesult.HasRows)
                    {
                        dr_reesult.Read();
                        obj_marca.id_empresa = int.Parse(dr_reesult["id_empresa"].ToString());
                        obj_marca.cod_iso_idio_orgn = dr_reesult["cod_iso_idio_orgn"].ToString();
                        obj_marca.cod_marca=dr_reesult["cod_marca"].ToString();
                        obj_marca.txt_abrv = dr_reesult["txt_abrv"].ToString();
                        obj_marca.txt_desc=dr_reesult["txt_desc"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj_marca;
        }
        public static void Marca_Insertar(SqlConnection conn, CEMarca obj_marca)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_marca_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_marca.id_empresa;
                    cmd.Parameters.Add("@cod_iso_idio_orgn", SqlDbType.VarChar,2).Value = obj_marca.cod_iso_idio_orgn;
                    cmd.Parameters.Add("@cod_marca", SqlDbType.VarChar, 3).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar,10).Value = obj_marca.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar,50).Value = obj_marca.txt_desc;
                    cmd.ExecuteNonQuery();

                    obj_marca.cod_marca = cmd.Parameters["@cod_marca"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Marca_Actualizar(SqlConnection conn, CEMarca obj_marca)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_marca_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_empresa", SqlDbType.BigInt).Value = obj_marca.id_empresa;
                    //cmd.Parameters.Add("@cod_iso_idio_orgn", SqlDbType.VarChar, 2).Value = obj_marca.cod_iso_idio_orgn;
                    cmd.Parameters.Add("@cod_marca", SqlDbType.VarChar, 3).Value = obj_marca.cod_marca;
                    cmd.Parameters.Add("@txt_abrv", SqlDbType.VarChar, 10).Value = obj_marca.txt_abrv;
                    cmd.Parameters.Add("@txt_desc", SqlDbType.VarChar, 50).Value = obj_marca.txt_desc;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Marca_Eliminar(SqlConnection conn, string m_cod_marca)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_marca_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cod_marca", SqlDbType.VarChar,3).Value = m_cod_marca;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getMarcaAll()
        {
            
            String procedure = "usp_marca_Listar";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure,oSqlConnection);
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
