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
   public class CDMarca_Modelo
    {
       public static void Marca_Modelo_Insertar(SqlConnection conn, CEMarca_Modelo obj_marca_modelo)
       {
           try
           {
               using (SqlCommand cmd = new SqlCommand("usp_marca_modelo_Insert", conn))
               {
                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@cod_marca", SqlDbType.VarChar, 3).Value = obj_marca_modelo.cod_marca;
                   cmd.Parameters.Add("@cod_modelo", SqlDbType.VarChar, 3).Value = obj_marca_modelo.cod_modelo;
                   cmd.ExecuteNonQuery();
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static void Marca_Modelo_Eliminar(SqlConnection conn, string m_cod_marca)
       {
           try
           {
               using (SqlCommand cmd = new SqlCommand("usp_marca_modelo_Delete", conn))
               {
                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@cod_marca", SqlDbType.VarChar, 3).Value = m_cod_marca;
                   cmd.ExecuteNonQuery();
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable getMarca_ModeloAll()
       {

           String procedure = "usp_marca_modelo_Listar";
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
