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
    public partial class INFORMACION : Form
    {
        public INFORMACION()
        {
            InitializeComponent();

        }
        //EL BOTON VOLVER NOS LLEVA A LA PAGINA DE INICIO DE SESION
        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form INFORMACION = new MIVOTO2026();
            INFORMACION.Show();
        }
    }
}
