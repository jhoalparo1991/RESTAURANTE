using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Larticulos
    {

        static Darticulos a = new Darticulos();
        public static bool insertar(
            int depto, int seccion, int marca, string codigo, string descripcion, int unidad,
            decimal pventa, decimal pcompra, int inventariable, decimal stock_inicial, decimal hay,
            decimal stock_minimo,string vence, byte[] imagen,int estado
            )
        {
            a.DeptoId = depto;
            a.SeccionId = seccion;
            a.MarcaId = marca;
            a.Codigo = codigo;
            a.Descripcion = descripcion;
            a.UnidadId = unidad;
            a.PrecioVenta = pventa;
            a.PrecioCompra = pcompra;
            a.Inventariable = inventariable;
            a.StockInicial = stock_inicial;
            a.Hay = hay;
            a.StockMinimo = stock_minimo;
            a.Vence = vence;
            a.Imagen = imagen;
            a.Estado = estado;
            return Darticulos.insertar(a);
        }

        public static bool editar( int id,
             int depto, int seccion, int marca, string codigo, string descripcion, int unidad,
            decimal pventa, decimal pcompra, int inventariable, decimal stock_inicial,
            decimal stock_minimo, string vence, byte[] imagen, int estado
            )
        {
            a.Id = id;
            a.DeptoId = depto;
            a.SeccionId = seccion;
            a.MarcaId = marca;
            a.Codigo = codigo;
            a.Descripcion = descripcion;
            a.UnidadId = unidad;
            a.PrecioVenta = pventa;
            a.PrecioCompra = pcompra;
            a.Inventariable = inventariable;
            a.StockInicial = stock_inicial;
            a.StockMinimo = stock_minimo;
            a.Vence = vence;
            a.Imagen = imagen;
            a.Estado = estado;
            return Darticulos.editar(a);
        }

        public static void mostrar_articulos(ref DataTable dt,int estado,string buscar)
        {
            Darticulos.mostrar_articulos(ref dt,estado,buscar);
        }

        public static bool eliminar(int id)
        {
            return Darticulos.eliminar(id);
        }


    }
}
