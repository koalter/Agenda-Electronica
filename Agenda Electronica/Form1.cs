using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Electronica
{
    public partial class Form1 : Form
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        String[] nombres = { "", "", "", "", "", "", "", "", "", "" };
        String[] apellidos = { "", "", "", "", "", "", "", "", "", "" };
        String[] direcciones = { "", "", "", "", "", "", "", "", "", "" };
        String[] telefonos = { "", "", "", "", "", "", "", "", "", "" };
        String[] edad = { "", "", "", "", "", "", "", "", "", "" };

        int indice = 0;

        public Form1()
        {
            InitializeComponent();
            asignarValores(indice);
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            if (indice >= 9)
            {
                indice = -1;
            }

            indice++;

            lblIndice.Text = Convert.ToString(indice);

            asignarValores(indice);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (indice <= 0)
            {
                indice = 10;
            }

            indice--;

            lblIndice.Text = Convert.ToString(indice);

            asignarValores(indice);
        }

        private void asignarValores(int i)
        {
            txtNumero.Text = Convert.ToString(numeros[i]);
            txtNombre.Text = nombres[i];
            txtApellido.Text = apellidos[i];
            txtDireccion.Text = direcciones[i];
            txtEdad.Text = telefonos[i];
            txtTelefono.Text = edad[i];
        }
        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            nombres[indice] = txtNombre.Text;
            apellidos[indice] = txtApellido.Text;
            direcciones[indice] = txtDireccion.Text;
            telefonos[indice] = txtEdad.Text;
            edad[indice] = txtTelefono.Text;
        }
    }
}
