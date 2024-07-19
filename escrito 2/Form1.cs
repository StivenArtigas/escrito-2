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
                dataGridView1.DataSource = PersonaControladores.Listar();
            }
            else
            {
                MessageBox.Show("Complete los campos");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string id;
            string nombre;
            id = textIdModificar.Text;
            nombre = textNombreModificar.Text;
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere modificar la persona con el id {id}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                if (!textNombreModificar.Text.Equals("") && textBox2.Text.Equals(""))
                {
                    PersonaControladores.ModificarNombre(id, nombre);
                    dataGridView1.DataSource = PersonaControladores.Listar();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string id;
            id=textborrar.Text;
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar a la persona con el id {id}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                PersonaControladores.Borrar(id);
                dataGridView1.DataSource = PersonaControladores.Listar();
                MessageBox.Show("Persona eliminada");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PersonaControladores.Listar();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}