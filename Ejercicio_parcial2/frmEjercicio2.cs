using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_parcial2
{
    public partial class frmEjercicio02 : Form
    {
        public frmEjercicio02()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //valido si el usuario ingresó una frase
            if (this.txtFrase.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese una frase...");
                //ubica el cursor en el cuaderno de texto txtfrase
                this.txtFrase.Focus();
            }
            //creo el array de palabras
            string[] palabras = this.txtFrase.Text.Split(' ');
            this.lstPalabras.Items.Clear();

            //lleno el listbox con las palabras
            for (int i = 0; i < palabras.Length; i++)
            {
                this.lstPalabras.Items.Add(palabras[i] + "-->"+ palabras[i].Length +"caracteres...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola felices fiestas");
        }
    }
}
