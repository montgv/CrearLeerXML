using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CrearLeerXML
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSerializar_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Agenda));
            FileStream fsout;

            //Comprobamos si el fichero existe o no
            if (File.Exists("agenda.xml") == true)
            {
                //Abrimos el fichero en modo lectura y obtenemos los registros que hay dentro y lo guardamos en el ArrayList
                fsout = new FileStream("agenda.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                try
                {
                    using (fsout)
                    {
                        agenda = (Agenda)xs.Deserialize(fsout);
                    }
                }
                catch
                {
                }
                fsout = new FileStream("agenda.xml", FileMode.Open, FileAccess.Write, FileShare.None);
            } else
            {
                //Creamos el fichero
                fsout = new FileStream("agenda.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            }
            Contacto contacto = new Contacto
            {
                nombre = tbNombre.Text,
                apellidos = tbApellidos.Text,
                direccion = tbDireccion.Text,
                telefono = tbTelef.Text,
                email= tbEmail.Text
            };
            //Añadimos el nuevo contacto al ArrayList
            agenda.Contactos.Add(contacto);

            try {
                using (fsout)
                {
                    //Guardamos el ArrayList en el fichero xml
                    xs.Serialize(fsout, agenda);
                }
            } 
            catch 
            { 
            }
        }

        private void btIzquierda_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                //Movemos los contactos hacia la izquierda
                contador--;
                Contacto contacto = new Contacto();
                XmlSerializer xs = new XmlSerializer(typeof(Agenda));
                FileStream fsin = new FileStream("agenda.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                try
                {
                    using (fsin)
                    {
                        agenda = (Agenda)xs.Deserialize(fsin);
                        contacto = (Contacto)agenda.Contactos[contador];
                        tbNombre.Text = contacto.nombre;
                        tbApellidos.Text = contacto.apellidos;
                        tbDireccion.Text = contacto.direccion;
                        tbTelef.Text = contacto.telefono;
                        tbEmail.Text = contacto.email;
                    }
                }
                catch
                {
                }
            }
        }

        private void btDerecha_Click(object sender, EventArgs e)
        {
            if (contador < agenda.Contactos.Count-1)
            {
                //Movemos los contactos hacia la derecha
                contador++;
                Contacto contacto = new Contacto();
                XmlSerializer xs = new XmlSerializer(typeof(Agenda));
                FileStream fsin = new FileStream("agenda.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                try
                {
                    using (fsin)
                    {
                        agenda = (Agenda)xs.Deserialize(fsin);
                        contacto = (Contacto)agenda.Contactos[contador];
                        tbNombre.Text = contacto.nombre;
                        tbApellidos.Text = contacto.apellidos;
                        tbDireccion.Text = contacto.direccion;
                        tbTelef.Text= contacto.telefono;
                        tbEmail.Text= contacto.email;
                    }
                }
                catch
                {
                }
            }
        }
    }
}
