using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Dunidades
    {

        public int Id { get; set; }
        public string NombreLargo { get; set; }
        public string NombreCorto { get; set; }
        public int Estado { get; set; }

        public static bool insertar(Dunidades unidades)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_presentaciones_insertar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_largo", unidades.NombreLargo);
                cmd.Parameters.AddWithValue("@nombre_corto", unidades.NombreCorto);
                cmd.Parameters.AddWithValue("@estado", unidades.Estado);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public static bool editar(Dunidades unidades)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_presentaciones_editar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_largo", unidades.NombreLargo);
                cmd.Parameters.AddWithValue("@nombre_corto", unidades.NombreCorto);
                cmd.Parameters.AddWithValue("@id", unidades.Id);
                cmd.Parameters.AddWithValue("@estado", unidades.Estado);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public static bool eliminar(int id)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_presentaciones_eliminar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public static void mostrar(ref DataTable dt,int estado)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter adapter = new SqlDataAdapter("sp_presentaciones_mostrar", Conexion.con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("estado", estado);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                dt = null;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

    }
}
