using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CrearLeerXML
{
    public class Agenda
    {
        [XmlArrayItem("Contacto", typeof(Contacto)), XmlArray("Agenda")]
        public System.Collections.ArrayList Contactos;

        public Agenda()
        {
            Contactos = new System.Collections.ArrayList();
        }
    }
}
