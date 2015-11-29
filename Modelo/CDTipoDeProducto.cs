using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CDTipoDeProducto
    {
        public DataTable getTipoProductolistar()
        {

            String procedure = "sp_listar_TipodeProducto";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConexion oCDConnection = new CDConexion();
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
        public DataTable llenar_combobox()
        {
            String procedure = "llenar_combobox";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConexion oCDConnection = new CDConexion();
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
        public DataTable llenar_combobox2()
        {
            String procedure = "llenar_combobox2";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConexion oCDConnection = new CDConexion();
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
        public DataTable llenar_combobox3()
        {
            String procedure = "llenar_combobox3";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConexion oCDConnection = new CDConexion();
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

        public DataTable llenar_combobox4()
        {
            String procedure = "llenar_combobox4";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConexion oCDConnection = new CDConexion();
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
        public DataTable gettipoproducto_eliminar(string cod_tipo)
        {
            string procedure = "sp_eliminar_tipodeproducto";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConexion oCDConnection = new CDConexion();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add("@cod_tipo", SqlDbType.Char, 4).Value = cod_tipo;
                //oSqlCommand.ExecuteNonQuery();
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
        public bool getTipoProducto_insertar(Entidad.TipoDeProducto oFamilia)
        {
            CDConexion ocd = new CDConexion();
            SqlConnection oconexion = ocd.openDB();
            SqlCommand oSqlCommand = new SqlCommand("sp_insertar_tipoproducto", oconexion);
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.Parameters.Add("@id_empresa", SqlDbType.Int).Value = oFamilia.id_Empresa;
            oSqlCommand.Parameters.Add("@cod_iso", SqlDbType.VarChar, 2).Value = oFamilia.Cod_iso_idio;
            oSqlCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 3).Value = oFamilia.cod_cate;
            oSqlCommand.Parameters.Add("@codigo_clase", SqlDbType.VarChar, 3).Value = oFamilia.cod_clase;
            oSqlCommand.Parameters.Add("@cod_tipo", SqlDbType.VarChar, 4).Value = oFamilia.cod_tipo;
            oSqlCommand.Parameters.Add("@abrv", SqlDbType.VarChar, 10).Value = oFamilia.txt_abrv;
            oSqlCommand.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = oFamilia.txt_desc;
            try
            {
                oSqlCommand.ExecuteNonQuery();
                oconexion.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        public bool actualizartipoproducto(Entidad.TipoDeProducto oFamilia)
        {
            CDConexion ocd = new CDConexion();
            SqlConnection oconexion = ocd.openDB();
            SqlCommand oSqlCommand = new SqlCommand("sp_actualizar_tipoproducto", oconexion);
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.Parameters.Add("@id_empresa", SqlDbType.Int).Value = oFamilia.id_Empresa;
            oSqlCommand.Parameters.Add("@cod_iso", SqlDbType.VarChar, 2).Value = oFamilia.Cod_iso_idio;
            oSqlCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 3).Value = oFamilia.cod_cate;
            oSqlCommand.Parameters.Add("@codigo_clase", SqlDbType.VarChar, 3).Value = oFamilia.cod_clase;
            oSqlCommand.Parameters.Add("@cod_tipo", SqlDbType.VarChar, 4).Value = oFamilia.cod_tipo;
            oSqlCommand.Parameters.Add("@abrv", SqlDbType.VarChar, 10).Value = oFamilia.txt_abrv;
            oSqlCommand.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = oFamilia.txt_desc;


            oSqlCommand.ExecuteNonQuery();
            oconexion.Close();
            return true;

        }
    }
        
}
