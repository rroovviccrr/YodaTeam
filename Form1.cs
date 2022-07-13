namespace Avancell_HungryTeam
{
    public partial class MIVOTO2026 : Form
    {
        public MIVOTO2026()
        {
            InitializeComponent();
        }

        //Boton salir
        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres salir la pagina?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Pogramamos los mensajes del tooltip
        private void MIVOTO2026_Load(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(btnvotar, "Al darle clik, inicias sesion para votar");
            this.toolTip1.SetToolTip(btnadministracion, "Solo ingresan administradores");
            this.toolTip1.SetToolTip(btninformacion, "Puedes ver la informacion de los partidos politicos");
        }
        //BOTON VOTAR NOS MUESTRA EL FORM PARA INICIAR SESION
        private void btnvotar_Click(object sender, EventArgs e)
        {
            Form mivoto2026 = new votar();
            mivoto2026.Show();
        }

        //BOTON INFORMACION NOS MUESTRA FORM DE LA INFO DE LOS PARTIDOS
        private void btninformacion_Click(object sender, EventArgs e)
        {
            Form mivoto2026 = new INFORMACION();
            mivoto2026.Show();
        }

        private void btnadministracion_Click(object sender, EventArgs e)
        {
            Form mivoto2026 = new Administrador();
            mivoto2026.Show();
        }


    }
}