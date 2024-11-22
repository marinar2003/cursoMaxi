using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desafio2
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Edad = txtEdad.Text;

            listResultado.Items.Add("Nombre y Apellido: " + persona.Nombre + " " + persona.Apellido);
            listResultado.Items.Add("Direccion: " + persona.Direccion);
            listResultado.Items.Add("Edad: " + persona.Edad);

            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;


            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
