using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Dmesas
    {

        public int MesaId { get; set; }
        public string Mesa { get; set; }
        public int SalonId { get; set; }
        public string Estado { get; set; }
        public string Disponible { get; set; }
        public string Tipo { get; set; }

        public static bool insertar()
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_insertar_mesas", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        public static bool editar(Dmesas mesas)
        {
            try
            {
                Conexion.abrir();
                string sql = "update mesas set mesa=@mesa,tipo=@tipo where mesa_id = @mesa_id";
                SqlCommand cmd = new SqlCommand(sql, Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mesa_id", mesas.MesaId);
                cmd.Parameters.AddWithValue("@mesa", mesas.Mesa);
                cmd.Parameters.AddWithValue("@tipo", mesas.Tipo);
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

        public static void mostrar_por_id_salon(ref DataTable dt, int idSalon)
        {
            try
            {
                Conexion.abrir();
                string sql = " select * from v_mesas_salones vm  " +
                    " cross join configuraciones_mesas cm " +
                    " where vm.salon_id = @salon_id ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, Conexion.con);
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.Parameters.AddWithValue("salon_id", idSalon);
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


        public static bool aumentar_tamanio_mesa()
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_aumentar_tamanio_mesa", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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


        public static bool disminuir_tamanio_mesa()
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_disminuir_tamanio_mesa", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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


        public static bool aumentar_tamanio_fuente()
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_aumentar_tamanio_fuente", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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

        public static bool disminuir_tamanio_fuente()
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_disminuir_tamanio_fuente", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
