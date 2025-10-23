using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Si el usuario escribe su nombre en textBox1 y luego presiona button1, ¿cómo usarías el código MessageBox.Show(...) para que el mensaje muestre "Hola" seguido del nombre que está escrito en el textBox1?

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void tbNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Nombre = tbNombre.Text;
            MessageBox.Show("Holiss " + Nombre);
        }
    }
}
