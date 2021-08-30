using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Ldepartamentos
    {

        static Ddepartamentos m = new Ddepartamentos();

        public static bool insertar(string descripcion, string colorFondo, string colorTexto, int estado)
        {
            m.Descripcion = descripcion;
            m.ColorFondo = colorFondo;
            m.ColorTexto = colorTexto;
            m.Estado = estado;
            return Ddepartamentos.insertar(m);
        }

        public static bool editar(int id, string descripcion, string colorFondo,
            string colorTexto, int estado)
        {
            m.Id = id;
            m.Descripcion = descripcion;
            m.ColorFondo = colorFondo;
            m.ColorTexto = colorTexto;
            m.Estado = estado;
            return Ddepartamentos.editar(m);
        }


        public static void mostrar(ref DataTable dt, int estado)
        {
            Ddepartamentos.mostrar(ref dt, estado);
        }

        public static bool eliminar(int id)
        {
            return Ddepartamentos.eliminar(id);
        }

    }
}
