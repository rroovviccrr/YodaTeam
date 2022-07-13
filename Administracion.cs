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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void lblseleccionar_Click(object sender, EventArgs e)
        {

        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnreporte, "Descargas el reporte de las votaciones");
        }

        private void btnvovlver_Click(object sender, EventArgs e)
        {
            Form Administracion = new MIVOTO2026();
            Administracion.Show();
        }
    }
}
