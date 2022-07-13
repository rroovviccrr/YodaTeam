namespace Avancell_HungryTeam
{
    partial class MIVOTO2026
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MIVOTO2026));
            this.btnvotar = new System.Windows.Forms.Button();
            this.btnadministracion = new System.Windows.Forms.Button();
            this.btninformacion = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblvotar = new System.Windows.Forms.Label();
            this.Picpartidos = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Picpartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvotar
            // 
            this.btnvotar.BackColor = System.Drawing.Color.LightGray;
            this.btnvotar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvotar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvotar.Location = new System.Drawing.Point(583, 149);
            this.btnvotar.Name = "btnvotar";
            this.btnvotar.Size = new System.Drawing.Size(201, 53);
            this.btnvotar.TabIndex = 0;
            this.btnvotar.Text = "Votar";
            this.btnvotar.UseVisualStyleBackColor = false;
            this.btnvotar.Click += new System.EventHandler(this.btnvotar_Click);
            // 
            // btnadministracion
            // 
            this.btnadministracion.BackColor = System.Drawing.Color.LightGray;
            this.btnadministracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadministracion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadministracion.Location = new System.Drawing.Point(583, 224);
            this.btnadministracion.Name = "btnadministracion";
            this.btnadministracion.Size = new System.Drawing.Size(201, 53);
            this.btnadministracion.TabIndex = 1;
            this.btnadministracion.Text = "Administración";
            this.btnadministracion.UseVisualStyleBackColor = false;
            this.btnadministracion.Click += new System.EventHandler(this.btnadministracion_Click);
            // 
            // btninformacion
            // 
            this.btninformacion.BackColor = System.Drawing.Color.LightGray;
            this.btninformacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninformacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btninformacion.Location = new System.Drawing.Point(583, 305);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(201, 53);
            this.btninformacion.TabIndex = 2;
            this.btninformacion.Text = "Información";
            this.btninformacion.UseVisualStyleBackColor = false;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.LightGray;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.Location = new System.Drawing.Point(608, 400);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(136, 38);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblvotar
            // 
            this.lblvotar.AutoSize = true;
            this.lblvotar.BackColor = System.Drawing.Color.LightGray;
            this.lblvotar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblvotar.Location = new System.Drawing.Point(569, 50);
            this.lblvotar.Name = "lblvotar";
            this.lblvotar.Size = new System.Drawing.Size(246, 48);
            this.lblvotar.TabIndex = 4;
            this.lblvotar.Text = "Mi voto 2026";
            // 
            // Picpartidos
            // 
            this.Picpartidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picpartidos.BackgroundImage")));
            this.Picpartidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picpartidos.Location = new System.Drawing.Point(67, 28);
            this.Picpartidos.Name = "Picpartidos";
            this.Picpartidos.Size = new System.Drawing.Size(381, 472);
            this.Picpartidos.TabIndex = 5;
            this.Picpartidos.TabStop = false;
            // 
            // MIVOTO2026
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 554);
            this.Controls.Add(this.Picpartidos);
            this.Controls.Add(this.lblvotar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btninformacion);
            this.Controls.Add(this.btnadministracion);
            this.Controls.Add(this.btnvotar);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MIVOTO2026";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIVOTO2026";
            this.Load += new System.EventHandler(this.MIVOTO2026_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picpartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnvotar;
        private Button btnadministracion;
        private Button btninformacion;
        private Button btnsalir;
        private Label lblvotar;
        private PictureBox Picpartidos;
        private ToolTip toolTip1;
    }
}