namespace Bakup_SQLExpress
{
    partial class FormTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTareas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListaTareas = new System.Windows.Forms.ListBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BCerrar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.tmpKey = new DialogConecSQL2005.WinReg(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BBakup = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListaTareas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 438);
            this.panel1.TabIndex = 0;
            // 
            // ListaTareas
            // 
            this.ListaTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaTareas.FormattingEnabled = true;
            this.ListaTareas.Location = new System.Drawing.Point(0, 0);
            this.ListaTareas.Name = "ListaTareas";
            this.ListaTareas.Size = new System.Drawing.Size(280, 438);
            this.ListaTareas.TabIndex = 0;
            this.ListaTareas.DoubleClick += new System.EventHandler(this.ListaTareas_DoubleClick);
            // 
            // BAgregar
            // 
            this.BAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BAgregar.Image")));
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(296, 39);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(88, 40);
            this.BAgregar.TabIndex = 1;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BCerrar
            // 
            this.BCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BCerrar.Image")));
            this.BCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCerrar.Location = new System.Drawing.Point(294, 225);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(88, 40);
            this.BCerrar.TabIndex = 2;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(296, 105);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(88, 40);
            this.BEliminar.TabIndex = 3;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // tmpKey
            // 
            this.tmpKey.Clave = "Key";
            this.tmpKey.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.tmpKey.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BBakup
            // 
            this.BBakup.Image = ((System.Drawing.Image)(resources.GetObject("BBakup.Image")));
            this.BBakup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBakup.Location = new System.Drawing.Point(296, 166);
            this.BBakup.Name = "BBakup";
            this.BBakup.Size = new System.Drawing.Size(88, 44);
            this.BBakup.TabIndex = 4;
            this.BBakup.Text = "Generar Respaldó";
            this.BBakup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBakup.UseVisualStyleBackColor = true;
            this.BBakup.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Imagen
            // 
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Imagen.Image")));
            this.Imagen.Location = new System.Drawing.Point(307, 289);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(54, 49);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 5;
            this.Imagen.TabStop = false;
            this.Imagen.Visible = false;
            // 
            // FormTareas
            // 
            this.AcceptButton = this.BCerrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 438);
            this.ControlBox = false;
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.BBakup);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BCerrar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de tareas de respaldos de bases de datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTareas_FormClosing);
            this.Load += new System.EventHandler(this.FormTareas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListaTareas;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Button BEliminar;
        private DialogConecSQL2005.WinReg tmpKey;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BBakup;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Imagen;
    }
}