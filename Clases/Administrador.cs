using Base_de_datos.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static Base_de_datos.Formularios.Login;

namespace Base_de_datos.Clases
{
    internal class Administrador
    {
        public Administrador()
        {
            int idEmpleado = Login.IdEmpleado;
            string ad = idEmpleado.ToString();
        }
    }
}
