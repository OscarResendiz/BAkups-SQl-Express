namespace Bakup_SQLExpress
{
    partial class FormLicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicencia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.THHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TClave = new System.Windows.Forms.TextBox();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.RegLicencia = new DialogConecSQL2005.WinReg(this.components);
            this.TKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegLicenciaKey = new DialogConecSQL2005.WinReg(this.components);
            this.BGenerar = new System.Windows.Forms.Button();
            this.controladorValidador1 = new Validador.ControladorValidador(this.components);
            this.cTextoRequerido1 = new Validador.CTextoRequerido(this.components);
            this.cTextoRequerido2 = new Validador.CTextoRequerido(this.components);
            this.cTextoRequerido3 = new Validador.CTextoRequerido(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de serie del disco duro";
            // 
            // THHD
            // 
            this.THHD.Location = new System.Drawing.Point(225, 25);
            this.THHD.Name = "THHD";
            this.THHD.ReadOnly = true;
            this.THHD.Size = new System.Drawing.Size(173, 20);
            this.THHD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave 1";
            // 
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(225, 75);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(173, 20);
            this.TClave.TabIndex = 4;
            // 
            // BAceptar
            // 
            this.BAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BAceptar.Image")));
            this.BAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAceptar.Location = new System.Drawing.Point(225, 164);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(85, 40);
            this.BAceptar.TabIndex = 5;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BCancelar.Image")));
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(329, 164);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(85, 40);
            this.BCancelar.TabIndex = 6;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.UseVisualStyleBackColor = true;
            // 
            // RegLicencia
            // 
            this.RegLicencia.Clave = "Licencia";
            this.RegLicencia.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.RegLicencia.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS";
            // 
            // TKey
            // 
            this.TKey.Location = new System.Drawing.Point(225, 125);
            this.TKey.Name = "TKey";
            this.TKey.Size = new System.Drawing.Size(173, 20);
            this.TKey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Clave 2";
            // 
            // RegLicenciaKey
            // 
            this.RegLicenciaKey.Clave = "LicenciaKey";
            this.RegLicenciaKey.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.RegLicenciaKey.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS";
            // 
            // BGenerar
            // 
            this.BGenerar.Location = new System.Drawing.Point(271, 49);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(141, 23);
            this.BGenerar.TabIndex = 9;
            this.BGenerar.Text = "Generar llave";
            this.BGenerar.UseVisualStyleBackColor = true;
            this.BGenerar.Visible = false;
            this.BGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // controladorValidador1
            // 
            this.controladorValidador1.Boton = this.BAceptar;
            this.controladorValidador1.Enabled = true;
            // 
            // cTextoRequerido1
            // 
            this.cTextoRequerido1.ModoValidacion = Validador.ValidateMode.NINGUNO;
            this.cTextoRequerido1.TextBox = this.TKey;
            this.cTextoRequerido1.Validador = this.controladorValidador1;
            // 
            // cTextoRequerido2
            // 
            this.cTextoRequerido2.ModoValidacion = Validador.ValidateMode.NINGUNO;
            this.cTextoRequerido2.TextBox = this.THHD;
            this.cTextoRequerido2.Validador = this.controladorValidador1;
            // 
            // cTextoRequerido3
            // 
            this.cTextoRequerido3.ModoValidacion = Validador.ValidateMode.NINGUNO;
            this.cTextoRequerido3.TextBox = this.TClave;
            this.cTextoRequerido3.Validador = this.controladorValidador1;
            // 
            // FormLicencia
            // 
            this.AcceptButton = this.BAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancelar;
            this.ClientSize = new System.Drawing.Size(428, 225);
            this.ControlBox = false;
            this.Controls.Add(this.BGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TKey);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.TClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.THHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licencia";
            this.Load += new System.EventHandler(this.FormLicencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox THHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
        private DialogConecSQL2005.WinReg RegLicencia;
        private System.Windows.Forms.TextBox TKey;
        private System.Windows.Forms.Label label3;
        private DialogConecSQL2005.WinReg RegLicenciaKey;
        private System.Windows.Forms.Button BGenerar;
        private Validador.ControladorValidador controladorValidador1;
        private Validador.CTextoRequerido cTextoRequerido1;
        private Validador.CTextoRequerido cTextoRequerido2;
        private Validador.CTextoRequerido cTextoRequerido3;
    }
}