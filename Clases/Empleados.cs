using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_datos.Clases
{
    internal class Empleados
    {
        conexion conetar = new conexion();

        public class Empleado
        {
            public int id {get; set;}
            public string nombre { get; set;}
            public string apellido { get; set;}
            public string nombre_usuario { get; set;}
            public string Correo { get; set;}
            public int telefono { get; set;}
            public bool Administrador { get; set;}
            public DateTime fecha { get; set;}
            public string password { get; set;}
        }

        public void insertar(Empleado empleado)
        {


            // DateTime fecha = DateTime.Now;
        }
    }
}
