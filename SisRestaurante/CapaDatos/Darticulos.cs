using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace CapaDatos
{
    public class Darticulos
    {

        public int Id { get; set; }
        public int DeptoId { get; set; }
        public int SeccionId { get; set; }
        public int MarcaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int UnidadId { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Inventariable { get; set; }
        public decimal StockInicial { get; set; }
        public decimal Hay { get; set; }
        public decimal StockMinimo { get; set; }
        public string Vence { get; set; }
        public byte[] Imagen { get; set; }
        public int Estado { get; set; }

        public static bool insertar(Darticulos a)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_articulos_insertar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("depto_id", a.DeptoId);
                cmd.Parameters.AddWithValue("seccion_id", a.SeccionId);
                cmd.Parameters.AddWithValue("marca_id", a.MarcaId);
                cmd.Parameters.AddWithValue("codigo", a.Codigo);
                cmd.Parameters.AddWithValue("descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("presentacion_id", a.UnidadId);
                cmd.Parameters.AddWithValue("precio_venta", a.PrecioVenta);
                cmd.Parameters.AddWithValue("precio_compra", a.PrecioCompra);
                cmd.Parameters.AddWithValue("inventariable", a.Inventariable);
                cmd.Parameters.AddWithValue("stock_inicial", a.StockInicial);
                cmd.Parameters.AddWithValue("hay", a.Hay);
                cmd.Parameters.AddWithValue("stock_minimo", a.StockMinimo);
                cmd.Parameters.AddWithValue("vence", a.Vence);
                cmd.Parameters.AddWithValue("imagen", a.Imagen);
                cmd.Parameters.AddWithValue("estado", a.Estado);
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

        public static bool editar(Darticulos a)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_articulos_editar", Conexion.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", a.Id);
                cmd.Parameters.AddWithValue("depto_id", a.DeptoId);
                cmd.Parameters.AddWithValue("seccion_id", a.SeccionId);
                cmd.Parameters.AddWithValue("marca_id", a.MarcaId);
                cmd.Parameters.AddWithValue("codigo", a.Codigo);
                cmd.Parameters.AddWithValue("descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("presentacion_id", a.UnidadId);
                cmd.Parameters.AddWithValue("precio_venta", a.PrecioVenta);
                cmd.Parameters.AddWithValue("precio_compra", a.PrecioCompra);
                cmd.Parameters.AddWithValue("inventariable", a.Inventariable);
                cmd.Parameters.AddWithValue("stock_inicial", a.StockInicial);
                cmd.Parameters.AddWithValue("stock_minimo", a.StockMinimo);
                cmd.Parameters.AddWithValue("vence", a.Vence);
                cmd.Parameters.AddWithValue("imagen", a.Imagen);
                cmd.Parameters.AddWithValue("estado", a.Estado);
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

        public static void mostrar_articulos(ref DataTable dt,int estado,string buscar)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter adapter = new SqlDataAdapter("sp_articulos_mostrar", Conexion.con);
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

        public static bool eliminar(int id)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("sp_articulos_eliminar", Conexion.con);
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
