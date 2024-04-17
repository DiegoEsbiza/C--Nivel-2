using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Complete todos los campos antes para poder continuar");

                //Text box "apellido"
                if (txtApellido.Text == "")
                {
                    txtApellido.BackColor = Color.Red;
                    lblApellidoError.Text = "*Campo obligatorio";
                }
                else
                {
                    txtApellido.BackColor = System.Drawing.SystemColors.Window;
                    lblApellidoError.Text = "";
                }                

                //Text box "nombre"
                if (txtNombre.Text == "")
                {
                    txtNombre.BackColor = Color.Red;
                    lblNombreError.Text = "*Campo obligatorio";
                }
                else
                {
                    txtNombre.BackColor = System.Drawing.SystemColors.Window;
                    lblNombreError.Text = "";
                }

                //Text box "edad"
                if (txtEdad.Text == "")
                {
                    txtEdad.BackColor = Color.Red;
                    lblEdadError.Text = "*Campo obligatorio";
                }
                else
                {
                    txtEdad.BackColor = System.Drawing.SystemColors.Window;
                    lblEdadError.Text = "";
                }
               
                //Text box "dirección"
                if (txtDireccion.Text == "")
                {
                    txtDireccion.BackColor = Color.Red;
                    lblDireccionError.Text = "*Campo obligatorio";
                }
                else
                {
                    txtDireccion.BackColor = System.Drawing.SystemColors.Window;
                    lblDireccionError.Text = "";
                }
            }
            else 
            {
                String apellido = "Apellido : " + txtApellido.Text.ToUpper();
                String nombre = "Nombre: " + txtNombre.Text.ToUpper();
                String edad = "Edad: " + txtEdad.Text.ToString();
                String direccion = "Dirección: " + txtDireccion.Text.ToUpper();
                
                //Text box "resultado"
                txtResultado.Text = apellido + Environment.NewLine + nombre + Environment.NewLine + edad + Environment.NewLine + direccion;
                
                //Restauracion de campo "apellido"
                txtApellido.Text = "";
                txtApellido.BackColor = System.Drawing.SystemColors.Window;
                lblApellidoError.Text = "";

                //Restauracion de campo "nombre"
                txtNombre.Text = "";
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
                lblApellidoError.Text = "";

                //Restauracion de campo "edad"
                txtEdad.Text = "";
                txtEdad.BackColor = System.Drawing.SystemColors.Window;
                lblEdadError.Text = "";

                //Restauracion de campo "direccion"
                txtDireccion.Text = "";
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;
                lblEdadError.Text = "";
            }
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
