using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Lsalones
    {


        public static bool insertar(string nombre)
        {
            Dsalones s = new Dsalones();
            s.Nombre = nombre;
            return Dsalones.insertar(s);

        }

        public static bool editar(int id, string nombre)
        {
            Dsalones s = new Dsalones();
            s.Nombre = nombre;
            s.SalonId = id;
            return Dsalones.editar(s);

        }

        public static bool eliminar(int id)
        {
            return Dsalones.eliminar(id);
        }

        public static void mostrar(ref DataTable data)
        {
            Dsalones.mostrar(ref data);
        }

        public static int obtenerPrimerSalon()
        {
            return Dsalones.obtnerPrimerSalon();
        }

    }
}
