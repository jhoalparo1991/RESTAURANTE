using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Lsecciones
    {
        static Dsecciones s = new Dsecciones();

        public static bool insertar(int deptoId, string nombre,int estado)
        {
            s.DeptoId = deptoId;
            s.Descripcion = nombre;
            s.Estado = estado;
            return Dsecciones.insertar(s);
        }

        public static bool editar(int id, int deptoId, string nombre,int estado)
        {
            s.Id = id;
            s.DeptoId = deptoId;
            s.Descripcion = nombre;
            s.Estado = estado;
            return Dsecciones.editar(s);
        }

        public static void mostrar(ref DataTable dt,int estado)
        {
            Dsecciones.mostrar(ref dt, estado);
        }

        public static bool Eliminar(int id)
        {
            return Dsecciones.eliminar(id);
        }

        public static void mostrar_secciones_por_departamento(ref DataTable dt,int id_depto)
        {
            Dsecciones.mostrar_secciones_por_departamento(ref dt, id_depto);
        }

    }
}
