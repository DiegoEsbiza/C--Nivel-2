using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColor.Items.Add("Amarillo");
            cbColor.Items.Add("Azul");
            cbColor.Items.Add("Celeste");
            cbColor.Items.Add("Naranja");
            cbColor.Items.Add("Negro");
            cbColor.Items.Add("Rojo");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            //operador ternario
            string chocolate = chkChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string tipo;

            if (rbMuggle.Checked)
                tipo = "Muggle";
            else if (rbSquib.Checked)
                tipo = "Squib";
            else
                tipo = "Wizard";
            string color = cbColor.SelectedItem.ToString();
            string numero = numNumero.Value.ToString();

            string mensajeNombre = "Nombre: " + nombre;
            string mensajeFechaNacimiento = "Su fecha de nacimiento es: " + fechaNacimiento;
            string mensajeChocolate = chocolate;
            string mensajeTipo = "Es un: " + tipo;
            string mensajeColor = "Su color es: " + color;
            string mensajeNumero = "El número seleccionado es: " + numero;

            MessageBox.Show(mensajeNombre + ", " + mensajeFechaNacimiento + ", " + mensajeChocolate + ", " + mensajeTipo + ", " + mensajeColor + ", " + mensajeNumero);           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo;

            if (rbMuggle.Checked)
                tipo = "Muggle";
            else if (rbSquib.Checked)
                tipo = "Squib";
            else
                tipo = "Wizard";
            Persona persona = new Persona(txtNombre.Text, dtpFechaNacimiento.Value.ToString(), chkChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate", tipo, cbColor.SelectedItem.ToString(), numNumero.Value.ToString());

            lstLista.Items.Add(persona.nombre);
            lstLista.Items.Add(persona.fechaNacimiento);
            lstLista.Items.Add(persona.chocolate);
            lstLista.Items.Add(persona.tipo);
            lstLista.Items.Add(persona.color);
            lstLista.Items.Add(persona.numero);
        }
    }
}
