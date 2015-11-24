using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class CDuser
    {
        public Boolean userValidate(CEuser oCEUser)
        {
            bool result = false;
            String procedure = "spGetUser";
            try
            {
                SqlConnection oSqlConnection = new SqlConnection();
                CDConnection oCDConnection = new CDConnection();
                oSqlConnection= oCDConnection.openDB();
                SqlCommand oSqlCommand = oSqlConnection.CreateCommand();
                oSqlCommand.CommandText = procedure;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Parameters.Add("@id",SqlDbType.VarChar,25).Value=oCEUser.id_usuario;
                oSqlCommand.Parameters.Add("@clave", SqlDbType.VarChar, 25).Value = oCEUser.clave;
                SqlDataReader oSqlDataReader= oSqlCommand.ExecuteReader();
                if (oSqlDataReader.HasRows)
                {
                   result = true;
                }

                return result;
            }
            catch(Exception e)
            {
                e.ToString();
                return result;
            }            
        }
    }
}
