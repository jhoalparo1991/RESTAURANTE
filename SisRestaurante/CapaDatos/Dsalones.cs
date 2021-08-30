using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace CapaDatos
{
    public class Dsalones
    {

        public int SalonId { get; set; }
        public string Nombre { get; set; }

        public static bool insertar(Dsalones salones)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("insert into salones(nombre)values(@nombre)", Conexion.con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", salones.Nombre);
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

        public static bool editar(Dsalones salones)
        {
            try
            {
                Conexion.abrir();
                string sql = " update salones set" +
                    " nombre = @nombre" +
                    " where salon_id=@salon_id ";
                SqlCommand cmd = new SqlCommand(sql, Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", salones.Nombre);
                cmd.Parameters.AddWithValue("@salon_id", salones.SalonId);
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

        public static bool eliminar(int idSalon)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_eliminar_salon", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("salon_id", idSalon);
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

        public static void mostrar(ref DataTable dt)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from salones", Conexion.con);
                adapter.SelectCommand.CommandType = CommandType.Text;
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

        public static int obtnerPrimerSalon()
        {
            int salon = 0;
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("select top(1) salon_id from salones", Conexion.con);
                cmd.CommandType = System.Data.CommandType.Text;
                salon = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                salon = 0;
            }
            finally
            {
                Conexion.cerrar();
            }
            return salon;
        }
    }
}
