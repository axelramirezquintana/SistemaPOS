using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibreriaDLL
{
    public class Biblioteca
    {
        public static DataSet Herramientas(string cmd)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Sistema;Integrated Security=True");
            conexion.Open();

            DataSet dll = new DataSet();
            SqlDataAdapter dll1 = new SqlDataAdapter(cmd, conexion);

            dll1.Fill(dll);

            conexion.Close();

            return dll;
        }


        }
}
