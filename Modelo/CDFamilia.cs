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
    public class CDFamilia
    {
        string error = "";     
        public DataTable getFamilialistar()
        {

            String procedure = "sp_listar_categoria";
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
        //public DataTable insertar(Familia ofamilia)
        //{
          //  try
            //{
              //  CDConnection oCD = new CDConnection();
                //SqlConnection oSqlConnection = oCD.openDB();
                //SqlCommand SqlCommand = new SqlCommand("sp_insertar_categoria", oSqlConnection);
                //SqlCommand.CommandType = CommandType.StoredProcedure;
                //SqlCommand.Parameters.Add("@id_Familia", SqlDbType.Char, 3).Value = ofamilia.Id_Familia;
                //SqlCommand.Parameters.Add("@Nombre", SqlDbType.Char, 50).Value = ofamilia.Nombre;                   
                //oSqlConnection.Open();
                //SqlCommand.ExecuteNonQuery();
                //oSqlConnection.Close();
            //}
            //atch (System.Exception ex)
            //{
              // error = "Error: " + ex.Message;
           // }
            //return error;  
 
//        }
        
        public DataTable Buscar(string Nombre)
        {

            String procedure = "sp_buscar_familia";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = Nombre;
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
       public bool getFamilia_insertar(Entidad.Familia oFamilia)
       {
         CDConnection ocd = new CDConnection();
       SqlConnection oconexion = ocd.openDB();
         SqlCommand oSqlCommand = new SqlCommand("sp_insertar_categoria", oconexion);
         oSqlCommand.CommandType = CommandType.StoredProcedure;
         oSqlCommand.Parameters.Add("@id_empresa", SqlDbType.Int).Value = oFamilia.id_Empresa;
         oSqlCommand.Parameters.Add("@cod_iso", SqlDbType.VarChar, 2).Value = oFamilia.cod_iso_idio;
         oSqlCommand.Parameters.Add("@codigo",SqlDbType.VarChar,3).Value = oFamilia.Id_Familia;
         oSqlCommand.Parameters.Add("@abrv",SqlDbType.VarChar,10).Value = oFamilia.Nombre;
         oSqlCommand.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = oFamilia.descripcion;
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
        public bool getFamilia_actualizar (Entidad.Familia ofamilia)
        {

            CDConnection ocd = new CDConnection();
            SqlConnection oconexion = ocd.openDB();
            SqlCommand oSqlCommand = new SqlCommand("sp_actualizar_categoria", oconexion);
            oSqlCommand.CommandType = CommandType.StoredProcedure;
            oSqlCommand.Parameters.Add("@id_Empresa", SqlDbType.Int).Value = ofamilia.id_Empresa;
            oSqlCommand.Parameters.Add("@cod_iso_idio", SqlDbType.VarChar, 2).Value = ofamilia.cod_iso_idio;
            oSqlCommand.Parameters.Add("@cod_cat", SqlDbType.VarChar,3).Value = ofamilia.Id_Familia;
            oSqlCommand.Parameters.Add("@abrv", SqlDbType.VarChar,10).Value = ofamilia.Nombre;
            oSqlCommand.Parameters.Add("@desc", SqlDbType.VarChar,50).Value = ofamilia.descripcion;
            oSqlCommand.ExecuteNonQuery();
            oconexion.Close();
            return true;
            
        }
        public DataTable getFammilia_eliminar(string Id_Famila)
        {
            string procedure = "sp_eliminar_categoria";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection = oCDConnection.openDB();
                SqlCommand oSqlCommand = new SqlCommand(procedure, oSqlConnection);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add("@cod_cate", SqlDbType.VarChar, 3).Value = Id_Famila;
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
            }
}
