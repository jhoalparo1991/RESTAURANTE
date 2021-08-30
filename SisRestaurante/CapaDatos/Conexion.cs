using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {

        public static SqlConnection con = new SqlConnection(Properties.Settings.Default.cnn);


        public static void abrir()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void cerrar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
