using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbEmpleados
{
    public class DataBaseManager
    {
        public static SqlConnection getConection()
        {
            SqlConnection conection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=test;Data Source=DESKTOP-89DQ4DK\\SQLEXPRESS");
                conection.Open();
            return conection;


        }

    }
}
