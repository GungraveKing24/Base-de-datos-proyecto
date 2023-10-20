using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_datos
{
    internal class conexion
    {
        public string conectar()
        {
            string Connection = "Server=localhost;Database=mecare;Uid=root;Pwd=852456;";

            return Connection;
        }
    }
}
