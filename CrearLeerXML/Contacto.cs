using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearLeerXML
{
    [Serializable]
    public class Contacto
    {
        private string Nombre;

        public string nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        private string Apellidos;

        public string apellidos
        {
            get
            {
                return Apellidos;
            }
            set
            {
                Apellidos = value;
            }
        }

        private string Direccion;

        public string direccion
        {
            get
            {
                return Direccion;
            }
            set
            {
                Direccion = value;
            }
        }

        private string Telefono;

        public string telefono
        {
            get
            {
                return Telefono;
            }
            set
            {
                Telefono = value;
            }
        }

        private string Email;

        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
    }
}
