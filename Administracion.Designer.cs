namespace Avancell_HungryTeam
{
    partial class Administracion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.lblseleccionar = new System.Windows.Forms.Label();
            this.btnreporte = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblprovincia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnvovlver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblseleccionar
            // 
            this.lblseleccionar.AutoSize = true;
            this.lblseleccionar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblseleccionar.Location = new System.Drawing.Point(227, 50);
            this.lblseleccionar.Name = "lblseleccionar";
            this.lblseleccionar.Size = new System.Drawing.Size(367, 38);
            this.lblseleccionar.TabIndex = 0;
            this.lblseleccionar.Text = "Selecciona la tarea a realizar";
            this.lblseleccionar.Click += new System.EventHandler(this.lblseleccionar_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.Location = new System.Drawing.Point(335, 206);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(123, 43);
            this.btnreporte.TabIndex = 1;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.UseVisualStyleBackColor = true;
            // 
            // lblprovincia
            // 
            this.lblprovincia.AutoSize = true;
            this.lblprovincia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblprovincia.Location = new System.Drawing.Point(261, 141);
            this.lblprovincia.Name = "lblprovincia";
            this.lblprovincia.Size = new System.Drawing.Size(96, 28);
            this.lblprovincia.TabIndex = 2;
            this.lblprovincia.Text = "Provincia:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "San Jose",
            "Alajuela",
            "Heredia",
            "Cartago",
            "Limon ",
            "Guanacaste",
            "Punta Arenas"});
            this.comboBox1.Location = new System.Drawing.Point(363, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // btnvovlver
            // 
            this.btnvovlver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvovlver.BackgroundImage")));
            this.btnvovlver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvovlver.Location = new System.Drawing.Point(722, 385);
            this.btnvovlver.Name = "btnvovlver";
            this.btnvovlver.Size = new System.Drawing.Size(55, 53);
            this.btnvovlver.TabIndex = 4;
            this.btnvovlver.UseVisualStyleBackColor = true;
            this.btnvovlver.Click += new System.EventHandler(this.btnvovlver_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvovlver);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblprovincia);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.lblseleccionar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblseleccionar;
        private Button btnreporte;
        private ToolTip toolTip1;
        private Label lblprovincia;
        private ComboBox comboBox1;
        private Button btnvovlver;
    }
}