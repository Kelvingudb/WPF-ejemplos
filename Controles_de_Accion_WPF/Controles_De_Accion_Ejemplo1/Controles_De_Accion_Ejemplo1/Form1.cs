using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_De_Accion_Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Evento para el botón
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Botón clicado!");
        }

        // Evento para el CheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Términos aceptados");
            }
            else
            {
                MessageBox.Show("Términos no aceptados");
            }
        }

        // Evento para los RadioButtons
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                MessageBox.Show($"Seleccionaste: {radioButton.Text}");
            }
        }

        // Evento para el ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            MessageBox.Show($"Seleccionaste: {comboBox.SelectedItem}");
        }

        // Evento para el ListBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            MessageBox.Show($"Seleccionaste: {listBox.SelectedItem}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
