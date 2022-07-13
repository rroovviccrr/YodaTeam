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
    public partial class votar : Form
    {
        public votar()
        {
            InitializeComponent();
        }

        //PARA SALIR DEL FORMULARIO
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form votar = new MIVOTO2026();
            votar.Show();
        }
        //LIMPAMOS TEXTBOX
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcontraseña.Clear();
            txtusuario.Clear(); 
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
           
        }
        
        //MOSTRAMOS EL FORMS PARA NUEVOS INGRESOS
        private void btnregistrarme_Click(object sender, EventArgs e)
        {
            Form votar = new NuevoIngreso();
            votar.Show();
        }

        private void votar_Load(object sender, EventArgs e)
        {

        }
    }
}
