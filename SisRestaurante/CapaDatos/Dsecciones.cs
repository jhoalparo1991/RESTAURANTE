using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace CapaDatos
{
    public class Dsecciones
    {

        public int Id { get; set; }
        public int DeptoId { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public static bool insertar(Dsecciones seccion)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_secciones_insertar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("depto_id", seccion.DeptoId);
                cmd.Parameters.AddWithValue("descripcion", seccion.Descripcion);
                cmd.Parameters.AddWithValue("estado", seccion.Estado);
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

        public static bool editar(Dsecciones seccion)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_secciones_editar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("depto_id", seccion.DeptoId);
                cmd.Parameters.AddWithValue("descripcion", seccion.Descripcion);
                cmd.Parameters.AddWithValue("estado", seccion.Estado);
                cmd.Parameters.AddWithValue("id", seccion.Id);
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
                SqlCommand cmd = new SqlCommand("sp_secciones_eliminar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id",id);
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
                SqlDataAdapter adapter = new SqlDataAdapter("sp_secciones_mostrar", Conexion.con);
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

        public static void mostrar_secciones_por_departamento(ref DataTable dt, int depto_id)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter adapter = new SqlDataAdapter("sp_mostrar_secciones_por_departamento", Conexion.con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@depto_id", depto_id);
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
