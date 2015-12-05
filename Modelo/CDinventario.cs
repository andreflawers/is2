using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Modelo
{
    public class CDinventario
    {
        public DataTable getInventarioList()
        {

            String procedure = "sp_listar_inv";
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
        public DataTable getGriewList(CEInventario oEntidad)
        {
            
            String procedure_alm = "sp_inv";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure_alm, oSqlConnection);
                oSqlCommand.CommandType=CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add("@nom_alm", SqlDbType.Char, 15).Value = oEntidad.almacen;
                oSqlCommand.Parameters.Add("@nom_est", SqlDbType.VarChar, 20).Value = oEntidad.tipo_Inventario;
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

        public DataTable getAlmacenList()
        {

            String procedure_alm = "sp_listar_alm";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure_alm, oSqlConnection);
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

        public DataTable getAllProducts()
        {
            string sp = "sp_inv_all";

            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(sp, oSqlConnection);
                SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                DataTable oDataTable = new DataTable();
                oSqlDataAdapter.Fill(oDataTable);
                return oDataTable;
            }
            catch
            {
                return null;
            }
        }

        
    }
}
