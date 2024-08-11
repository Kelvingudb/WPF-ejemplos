using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles__De_Accion_Ejemplo2
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
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Actualiza el valor de la barra de progreso según la posición del TrackBar
            progressBar1.Value = trackBar1.Value;
        }

        // Evento para NumericUpDown
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Muestra el valor seleccionado en el NumericUpDown
            MessageBox.Show($"Valor seleccionado: {numericUpDown1.Value}");
        }

        // Evento para DateTimePicker
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Muestra la fecha seleccionada
            MessageBox.Show($"Fecha seleccionada: {dateTimePicker1.Value.ToShortDateString()}");
        }

        // Evento para MaskedTextBox
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Notifica si el input es incorrecto en el MaskedTextBox
            MessageBox.Show("Entrada no válida, por favor verifica el formato.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
