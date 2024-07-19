using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace escrito_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals(""))
            {
                    PersonaControladores.alta(textBox1.Text, textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Se ah ingresado correctamente");
                }
            else
            {
                MessageBox.Show("Complete los campos");
            }
        }

}
