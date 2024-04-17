using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, ¿Qué tal?");
        }

        private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("chau chau ...");
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención!");
            //this.BackColor = Color.Blue;
            if (txtTexto.Text == "")
                txtTexto.BackColor = Color.Red;
            else
                txtTexto.BackColor = System.Drawing.SystemColors.Control;
            
        }

        private void MainWin_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el Click izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Click derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el Click central");
            
        }

        private void lblEtiqueta_MouseMove_1(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.Cursor = Cursors.Hand;

        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtBox.Text.Length + " caracteres");
        }
    }
}
