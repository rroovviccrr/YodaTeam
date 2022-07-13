namespace Avancell_HungryTeam
{
    partial class NuevoIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoIngreso));
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblprovincia = new System.Windows.Forms.Label();
            this.lblcanton = new System.Windows.Forms.Label();
            this.btnlisto = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cmbprovincia = new System.Windows.Forms.ComboBox();
            this.cmbcanton = new System.Windows.Forms.ComboBox();
            this.gpbdireccion = new System.Windows.Forms.GroupBox();
            this.gpbdatos = new System.Windows.Forms.GroupBox();
            this.gpbdireccion.SuspendLayout();
            this.gpbdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(14, 98);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(166, 25);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre Completo:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(14, 47);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(121, 25);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Identificacion:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(14, 151);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(165, 25);
            this.lblnumero.TabIndex = 2;
            this.lblnumero.Text = "Numero Telefonico:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(14, 202);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(65, 25);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-mail:";
            // 
            // lblprovincia
            // 
            this.lblprovincia.AutoSize = true;
            this.lblprovincia.Location = new System.Drawing.Point(13, 38);
            this.lblprovincia.Name = "lblprovincia";
            this.lblprovincia.Size = new System.Drawing.Size(195, 25);
            this.lblprovincia.TabIndex = 4;
            this.lblprovincia.Text = "Provincia de residencia:";
            // 
            // lblcanton
            // 
            this.lblcanton.AutoSize = true;
            this.lblcanton.Location = new System.Drawing.Point(13, 87);
            this.lblcanton.Name = "lblcanton";
            this.lblcanton.Size = new System.Drawing.Size(181, 25);
            this.lblcanton.TabIndex = 5;
            this.lblcanton.Text = "Canton de residencia:";
            // 
            // btnlisto
            // 
            this.btnlisto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlisto.BackgroundImage")));
            this.btnlisto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlisto.Location = new System.Drawing.Point(646, 317);
            this.btnlisto.Name = "btnlisto";
            this.btnlisto.Size = new System.Drawing.Size(74, 70);
            this.btnlisto.TabIndex = 6;
            this.btnlisto.UseVisualStyleBackColor = true;
            this.btnlisto.Click += new System.EventHandler(this.btnlisto_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.BackgroundImage")));
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.Location = new System.Drawing.Point(646, 237);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(74, 70);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolver.BackgroundImage")));
            this.btnvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvolver.Location = new System.Drawing.Point(646, 161);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(74, 70);
            this.btnvolver.TabIndex = 8;
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(225, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(261, 31);
            this.txtid.TabIndex = 9;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(225, 97);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(261, 31);
            this.txtnombre.TabIndex = 10;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(225, 145);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(261, 31);
            this.txtnumero.TabIndex = 11;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(225, 199);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(261, 31);
            this.txtemail.TabIndex = 12;
            // 
            // cmbprovincia
            // 
            this.cmbprovincia.FormattingEnabled = true;
            this.cmbprovincia.Items.AddRange(new object[] {
            "San Jose",
            "Alajuela",
            "Heredia",
            "Cartago",
            "Limon",
            "Guanacaste ",
            "Punta Arenas"});
            this.cmbprovincia.Location = new System.Drawing.Point(224, 30);
            this.cmbprovincia.Name = "cmbprovincia";
            this.cmbprovincia.Size = new System.Drawing.Size(261, 33);
            this.cmbprovincia.TabIndex = 13;
            // 
            // cmbcanton
            // 
            this.cmbcanton.FormattingEnabled = true;
            this.cmbcanton.Location = new System.Drawing.Point(224, 87);
            this.cmbcanton.Name = "cmbcanton";
            this.cmbcanton.Size = new System.Drawing.Size(261, 33);
            this.cmbcanton.TabIndex = 14;
            // 
            // gpbdireccion
            // 
            this.gpbdireccion.Controls.Add(this.cmbcanton);
            this.gpbdireccion.Controls.Add(this.cmbprovincia);
            this.gpbdireccion.Controls.Add(this.lblcanton);
            this.gpbdireccion.Controls.Add(this.lblprovincia);
            this.gpbdireccion.Location = new System.Drawing.Point(68, 298);
            this.gpbdireccion.Name = "gpbdireccion";
            this.gpbdireccion.Size = new System.Drawing.Size(513, 142);
            this.gpbdireccion.TabIndex = 15;
            this.gpbdireccion.TabStop = false;
            this.gpbdireccion.Text = "Direccion :";
            // 
            // gpbdatos
            // 
            this.gpbdatos.Controls.Add(this.txtemail);
            this.gpbdatos.Controls.Add(this.txtnumero);
            this.gpbdatos.Controls.Add(this.txtnombre);
            this.gpbdatos.Controls.Add(this.txtid);
            this.gpbdatos.Controls.Add(this.lblemail);
            this.gpbdatos.Controls.Add(this.lblnumero);
            this.gpbdatos.Controls.Add(this.lblid);
            this.gpbdatos.Controls.Add(this.lblnombre);
            this.gpbdatos.Location = new System.Drawing.Point(68, 21);
            this.gpbdatos.Name = "gpbdatos";
            this.gpbdatos.Size = new System.Drawing.Size(501, 252);
            this.gpbdatos.TabIndex = 16;
            this.gpbdatos.TabStop = false;
            this.gpbdatos.Text = "Datos:";
            // 
            // NuevoIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.gpbdatos);
            this.Controls.Add(this.gpbdireccion);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnlisto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoIngreso";
            this.Load += new System.EventHandler(this.NuevoIngreso_Load);
            this.gpbdireccion.ResumeLayout(false);
            this.gpbdireccion.PerformLayout();
            this.gpbdatos.ResumeLayout(false);
            this.gpbdatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblnombre;
        private Label lblid;
        private Label lblnumero;
        private Label lblemail;
        private Label lblprovincia;
        private Label lblcanton;
        private Button btnlisto;
        private Button btnlimpiar;
        private Button btnvolver;
        private TextBox txtid;
        private TextBox txtnombre;
        private TextBox txtnumero;
        private TextBox txtemail;
        private ComboBox cmbprovincia;
        private ComboBox cmbcanton;
        private GroupBox gpbdireccion;
        private GroupBox gpbdatos;
    }
}