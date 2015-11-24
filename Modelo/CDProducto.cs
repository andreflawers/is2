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
    public class CDProducto
    {
        public DataTable getProductoList()
        {

            String procedure = "spProductoList";
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

        public int productoCreate(CEProducto oCEProducto)
        {
            String procedure = "spProductoCreate";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add("@descripción_Producto",SqlDbType.VarChar,50).Value= oCEProducto.descripción_Producto;
                oSqlCommand.Parameters.Add("@cantidad_Producto", SqlDbType.Int).Value = oCEProducto.cantidad_Producto;
                oSqlCommand.Parameters.Add("@precio_Producto", SqlDbType.Money).Value = oCEProducto.precio_Producto;
                oSqlCommand.Parameters.Add("@Id_SubFamilia", SqlDbType.Char, 3).Value = oCEProducto.Id_SubFamilia;
                oSqlCommand.Parameters.Add("@id_marca", SqlDbType.Char, 3).Value = oCEProducto.id_marca;
                oSqlCommand.Parameters.Add("@id_Presentacion", SqlDbType.Char, 3).Value = oCEProducto.id_Presentacion;
                oSqlCommand.Parameters.Add("@id_Producto", SqlDbType.Int).Direction = ParameterDirection.Output;
                oSqlCommand.ExecuteNonQuery();
                oCEProducto.id_Producto = int.Parse(oSqlCommand.Parameters["@id_Producto"].Value.ToString());
                return oCEProducto.id_Producto;
            }
            catch (Exception e)
            {
                e.ToString();
                return 0;
            }
        }
    }
}
