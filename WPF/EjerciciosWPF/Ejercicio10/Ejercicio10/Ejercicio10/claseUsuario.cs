using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Usuario
    {
        public string nombre { set; get; }
        public string dni { set; get; }
        public string usuario { set; get; }
        public string pwd { set; get; }

        public Usuario(string nombre, string dni, string usuario, string pwd)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.usuario = usuario;
            this.pwd = pwd;
        }
    }
}
