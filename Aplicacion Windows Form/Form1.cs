using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Aplicacion_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Queremos que al hacer clic en el button1:
        //El programa revise si el tbNombre está vacío.
        //Si(if) está vacío, debe mostrar un MessageBox que diga "Por favor, escribe tu nombre".
        //Si no(else), debe mostrar el MessageBox que ya tenías: "Holiss " + el nombre.

        public void tbNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Por favor, escribe tu nombre");
            }
            else
            {
                String Nombre = tbNombre.Text;
                MessageBox.Show("Holiss " + Nombre);
            }
        }
    }
}
