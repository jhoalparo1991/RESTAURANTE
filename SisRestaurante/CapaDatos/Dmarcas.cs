using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace CapaDatos
{
    public class Dmarcas
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }

        public static bool insertar(Dmarcas marcas)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_marcas_insertar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", marcas.Nombre);
                cmd.Parameters.AddWithValue("@estado", marcas.Estado);
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

        public static bool editar(Dmarcas marcas)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_marcas_editar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", marcas.Nombre);
                cmd.Parameters.AddWithValue("@estado", marcas.Estado);
                cmd.Parameters.AddWithValue("@id", marcas.Id);
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
                SqlCommand cmd = new SqlCommand("sp_marcas_eliminar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);
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

        public static void mostrar(ref DataTable dt, int estado)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter adapter = new SqlDataAdapter("sp_marcas_mostrar", Conexion.con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@estado", estado);
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
