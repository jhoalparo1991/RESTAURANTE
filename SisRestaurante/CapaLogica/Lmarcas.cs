using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Lmarcas
    {
        static Dmarcas m = new Dmarcas();

        public static bool insertar(string descripcion, int estado)
        {
            m.Nombre = descripcion;
            m.Estado = estado;
            return Dmarcas.insertar(m);
        }

        public static bool editar(int id, string descripcion, int estado)
        {
            m.Nombre = descripcion;
            m.Id = id;
            m.Estado = estado;
            return Dmarcas.editar(m);
        }

        public static bool eliminar(int id)
        {
            return Dmarcas.eliminar(id);
        }

        public static void mostrar(ref DataTable dt, int estado)
        {
            Dmarcas.mostrar(ref dt, estado);
        }
    }
}
