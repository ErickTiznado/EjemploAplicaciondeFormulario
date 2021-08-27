using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploAplicaciondeFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAcpt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de Mensaje Aceptar", "Aceptar");
        }

        private void btnacptcancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de Mensaje Aceptar/Cancelar", "Aceptar/Cancelar",MessageBoxButtons.OKCancel );
        }

        private void btnSiNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de Mensaje Si/No", "Si/No", MessageBoxButtons.YesNo);

        }

        private void btnExclamacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de Mensaje Exclamacion", "Exclamacion", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Exclamation);
        }

        private void btnInterrogacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de Mensaje Interrogacion", "Interrogacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void Error_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de Mensaje Error", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
        }
    }
}
