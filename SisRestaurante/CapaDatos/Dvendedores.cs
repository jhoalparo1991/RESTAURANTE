using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaDatos
{
   public class Dvendedores
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string NombreCorto { get; set; }
        public string Sexo { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public byte[] Foto { get; set; }
        public string Clave { get; set; }
        public string FechaNac { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Comision { get; set; }
        public int Estado { get; set; }
        public int Login { get; set; }
        public int RolId { get; set; }

        public static void mostrar(ref DataTable dt, int estado, string buscar)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter adapter = new SqlDataAdapter("sp_vendedores_mostrar", Conexion.con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@estado", estado);
                adapter.SelectCommand.Parameters.AddWithValue("@buscar", buscar);
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

        public static bool insertar(Dvendedores v)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_vendedores_insertar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", v.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", v.Apellidos);
                cmd.Parameters.AddWithValue("@documento", v.Documento);
                cmd.Parameters.AddWithValue("@nombre_corto", v.NombreCorto);
                cmd.Parameters.AddWithValue("@sexo", v.Sexo);
                cmd.Parameters.AddWithValue("@ciudad", v.Ciudad);
                cmd.Parameters.AddWithValue("@direccion", v.Direccion);
                cmd.Parameters.AddWithValue("@barrio", v.Barrio);
                cmd.Parameters.AddWithValue("@telefono", v.Telefono);
                cmd.Parameters.AddWithValue("@celular", v.Celular);
                cmd.Parameters.AddWithValue("@correo", v.Correo);
                cmd.Parameters.AddWithValue("@foto", v.Foto);
                cmd.Parameters.AddWithValue("@clave", v.Clave);
                cmd.Parameters.AddWithValue("@fecha_nac", v.FechaNac);
                cmd.Parameters.AddWithValue("@salario_base", v.SalarioBase);
                cmd.Parameters.AddWithValue("@comision", v.Comision);
                cmd.Parameters.AddWithValue("@estado", v.Estado);
                cmd.Parameters.AddWithValue("@login", v.Login);
                cmd.Parameters.AddWithValue("@rol_id", v.RolId);
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

        public static bool editar(Dvendedores v)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_vendedores_editar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", v.Id);
                cmd.Parameters.AddWithValue("@nombres", v.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", v.Apellidos);
                cmd.Parameters.AddWithValue("@documento", v.Documento);
                cmd.Parameters.AddWithValue("@nombre_corto", v.NombreCorto);
                cmd.Parameters.AddWithValue("@sexo", v.Sexo);
                cmd.Parameters.AddWithValue("@ciudad", v.Ciudad);
                cmd.Parameters.AddWithValue("@direccion", v.Direccion);
                cmd.Parameters.AddWithValue("@barrio", v.Barrio);
                cmd.Parameters.AddWithValue("@telefono", v.Telefono);
                cmd.Parameters.AddWithValue("@celular", v.Celular);
                cmd.Parameters.AddWithValue("@correo", v.Correo);
                cmd.Parameters.AddWithValue("@foto", v.Foto);
                cmd.Parameters.AddWithValue("@clave", v.Clave);
                cmd.Parameters.AddWithValue("@fecha_nac", v.FechaNac);
                cmd.Parameters.AddWithValue("@salario_base", v.SalarioBase);
                cmd.Parameters.AddWithValue("@comision", v.Comision);
                cmd.Parameters.AddWithValue("@estado", v.Estado);
                cmd.Parameters.AddWithValue("@rol_id", v.RolId);
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
                SqlCommand cmd = new SqlCommand("sp_vendedores_eliminar", Conexion.con);
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
