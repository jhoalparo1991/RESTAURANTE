using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Lunidades
    {
        static Dunidades u = new Dunidades();
        public static bool insertar(string nombreLargo, string nombreCorto, int estado)
        {
            u.NombreLargo = nombreLargo;
            u.NombreCorto = nombreCorto;
            u.Estado = estado;
            return Dunidades.insertar(u);
        }

        public static bool editar(int id, string nombreLargo, string nombreCorto, int estado)
        {
            u.Id = id;
            u.NombreLargo = nombreLargo;
            u.NombreCorto = nombreCorto;
            u.Estado = estado;

            return Dunidades.editar(u);
        }

        public static bool eliminar(int id)
        {
            return Dunidades.eliminar(id);
        }

        public static void mostrar(ref DataTable dt,int estado)
        {
            Dunidades.mostrar(ref dt,estado);
        }
    }


}
