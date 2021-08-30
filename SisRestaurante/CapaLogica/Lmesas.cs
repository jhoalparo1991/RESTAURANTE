using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Lmesas
    {
        public static bool insertar()
        {
            return Dmesas.insertar();
        }

        public static bool editar(int id_mesa, string nombre, string tipo)
        {
            Dmesas m = new Dmesas();
            m.MesaId = id_mesa;
            m.Mesa = nombre;
            m.Tipo = tipo;
            return Dmesas.editar(m);
        }

        public static void mostrar_por_id_salon(int idsalon, ref DataTable dt)
        {
            Dmesas.mostrar_por_id_salon(ref dt, idsalon);
        }

        public static bool aumentar_tamanio_mesa()
        {
            return Dmesas.aumentar_tamanio_mesa();
        }

        public static bool disminuir_tamanio_mesa()
        {
            return Dmesas.disminuir_tamanio_mesa();
        }

        public static bool aumentar_tamanio_fuente()
        {
            return Dmesas.aumentar_tamanio_fuente();
        }

        public static bool disminuir_tamanio_fuente()
        {
            return Dmesas.disminuir_tamanio_fuente();
        }


    }
}
