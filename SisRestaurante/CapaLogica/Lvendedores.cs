using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Lvendedores
    {
        public static void Mostrar(ref DataTable dt,int estado,string buscar)
        {
            Dvendedores.mostrar(ref dt, estado, buscar);
        }

        public static bool Eliminar(int id)
        {
            return Dvendedores.eliminar(id);
        }

        public static bool Insertar(string nombres,string apellidos,string documento,string nombre_corto,
            string sexo,string ciudad,string direccion,string barrio,string telefono,string celular,
            string correo,byte[] foto,string clave,string fecha_nac,decimal salario,
            decimal comision,int estado,int login,int rol_id)
        {
            Dvendedores v = new Dvendedores();
            v.Nombres = nombres;
            v.Apellidos = apellidos;
            v.Documento = documento;
            v.NombreCorto = nombre_corto;
            v.Sexo = sexo;
            v.Ciudad = ciudad;
            v.Direccion = direccion;
            v.Barrio = barrio;
            v.Telefono = telefono;
            v.Celular = celular;
            v.Correo = correo;
            v.Foto = foto;
            v.Clave = clave;
            v.FechaNac = fecha_nac;
            v.SalarioBase = salario;
            v.Comision = comision;
            v.Estado = estado;
            v.Login = login;
            v.RolId = rol_id;
            return Dvendedores.insertar(v);
        }

        public static bool Editar(int id,string nombres, string apellidos, string documento, string nombre_corto,
           string sexo, string ciudad, string direccion, string barrio, string telefono, string celular,
           string correo, byte[] foto, string clave, string fecha_nac, decimal salario,
           decimal comision, int estado, int rol_id)
        {
            Dvendedores v = new Dvendedores();
            v.Nombres = nombres;
            v.Apellidos = apellidos;
            v.Documento = documento;
            v.NombreCorto = nombre_corto;
            v.Sexo = sexo;
            v.Ciudad = ciudad;
            v.Direccion = direccion;
            v.Barrio = barrio;
            v.Telefono = telefono;
            v.Celular = celular;
            v.Correo = correo;
            v.Foto = foto;
            v.Clave = clave;
            v.FechaNac = fecha_nac;
            v.SalarioBase = salario;
            v.Comision = comision;
            v.Estado = estado;
            v.RolId = rol_id;
            v.Id = id;
            return Dvendedores.editar(v);
        }
    }
}
