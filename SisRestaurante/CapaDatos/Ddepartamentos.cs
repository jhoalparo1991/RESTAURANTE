using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace CapaDatos
{
    public class Ddepartamentos
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string ColorFondo { get; set; }
        public string ColorTexto { get; set; }
        public int Estado { get; set; }

        public static bool insertar(Ddepartamentos depto)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_departamentos_insertar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", depto.Descripcion);
                cmd.Parameters.AddWithValue("@colorfondo", depto.ColorFondo);
                cmd.Parameters.AddWithValue("@colortexto", depto.ColorTexto);
                cmd.Parameters.AddWithValue("@estado", depto.Estado);
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

        public static bool editar(Ddepartamentos depto)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_departamentos_editar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", depto.Descripcion);
                cmd.Parameters.AddWithValue("@colorfondo", depto.ColorFondo);
                cmd.Parameters.AddWithValue("@colortexto", depto.ColorTexto);
                cmd.Parameters.AddWithValue("@estado", depto.Estado);
                cmd.Parameters.AddWithValue("@id", depto.Id);
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
                SqlDataAdapter adapter = new SqlDataAdapter("sp_departamentos_mostrar", Conexion.con);
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

        public static bool eliminar(int id)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_departamentos_eliminar", Conexion.con);
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
    }
}
