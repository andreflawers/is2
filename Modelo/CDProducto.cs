using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class CDProducto
    {
       public DataTable getProductolistar()
       {
           String procedure = "usp_Producto_Listar";
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
       public DataTable getProductoListDescripcion(string nombre)
       {

           String procedure = "usp_ProductoBusquedadDescrip";
           try
           {
               SqlConnection oSqlConnection = new SqlConnection();
               CDConnection oCDConnection = new CDConnection();
               oSqlConnection = oCDConnection.openDB();
               SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
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
       public DataTable getProductoListid(string nombre)
       {

           String procedure = "usp_Producto_BusquedaId";
           try
           {
               SqlConnection oSqlConnection = new SqlConnection();
               CDConnection oCDConnection = new CDConnection();
               oSqlConnection = oCDConnection.openDB();
               SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
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
       public DataTable getProductoListDescripcion_id(string id, string nombre)
       {

           String procedure = "usp_Producto_BusquedadIDDescrip";
           try
           {
               SqlConnection oSqlConnection = new SqlConnection();
               CDConnection oCDConnection = new CDConnection();
               oSqlConnection = oCDConnection.openDB();
               SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
               oSqlCommand.CommandType = CommandType.StoredProcedure;
               oSqlCommand.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = id;
               oSqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
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
