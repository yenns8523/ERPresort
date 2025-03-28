using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Resort_ERP
{
    class Connection
    {
         SqlConnection con = new SqlConnection("Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True");

        public string Get_connectionstring()
        { 
            string connectionstring= "Data Source=LAPTOPOFNGUYEN;Initial Catalog=resort;Integrated Security=True";
            connectionstring=Convert.ToString(con);
            return connectionstring;
        }
    }
}
