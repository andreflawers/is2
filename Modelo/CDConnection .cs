﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CDConnection
    {
        public SqlConnection openDB()
        {

            string lsConection = "Data Source=diego;Initial Catalog =db5Version2;Integrated Security=true;user=sa;password=1234";
            SqlConnection oConection = new SqlConnection(lsConection);
            try
            {
                oConection.Open();
                return oConection;
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }           
           
            
        }
    }
}
