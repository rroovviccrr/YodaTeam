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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcolaborador.Clear();
            txtcontra.Clear(); 
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form Administrador = new MIVOTO2026();
            Administrador.Show();
        }
    }
}
