using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avancell_HungryTeam
{
    public partial class NuevoIngreso : Form
    {
        public NuevoIngreso()
        {
            InitializeComponent();
        }

        private void NuevoIngreso_Load(object sender, EventArgs e)
        {

        }

        //VALIDAMOS SOLO NUMEROS Y SOLO LETRAS
        public void validartexto(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

                e.Handled = false;
            }
        }
        public void validarnumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

                e.Handled = false;
            }
        }

        //NOS DEVOLVEMOS A LA PANTALLA INICIAL CON EL BOTON VOLVER
        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form NuevoIngreso = new MIVOTO2026();
            NuevoIngreso.Show();
        }

        //NOS VAMOS A INICIAR SESION CON EL BOTON LISTO
        private void btnlisto_Click(object sender, EventArgs e)
        {
            Form NuevoIngreso = new votar();
            NuevoIngreso.Show();

        }

        //LIMPIAMOS CAMPOS
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control Datos in gpbdatos.Controls)
            {
                if (Datos is TextBox)
                    Datos.Text = string.Empty;

                else if (Datos is ComboBox)
                    Datos.Text = string.Empty;

            }

            foreach (Control Direccion in gpbdireccion.Controls)
            {
                if (Direccion is ComboBox)
                    Direccion.Text = string.Empty;
            }

            //AL LIMPIAR LOS CAMPOS NOS ENFOCAMOS EN EL TXTID PARA VOLVER A DIGITAR LA INFORMACION
            txtid.Focus();
        }

        //LLAMANDO A SOLO NUMEROS
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarnumeros(sender, e);
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarnumeros(sender, e);
        }

        //LLAMANDO SOLO LETRAS
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validartexto(sender, e);
        }

    }
    }




