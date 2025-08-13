namespace Bakup_SQLExpress
{
    partial class FormRegPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegPassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCAncelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.TContrseña = new System.Windows.Forms.TextBox();
            this.TContraseña2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.controladorValidador1 = new Validador.ControladorValidador(this.components);
            this.cTextoRequerido1 = new Validador.CTextoRequerido(this.components);
            this.cTextoRequerido2 = new Validador.CTextoRequerido(this.components);
            this.cTextoRequerido3 = new Validador.CTextoRequerido(this.components);
            this.RegPassword = new DialogConecSQL2005.WinReg(this.components);
            this.RegUsuario = new DialogConecSQL2005.WinReg(this.components);
            this.RegKey = new DialogConecSQL2005.WinReg(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BAceptar
            // 
            this.BAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BAceptar.Image")));
            this.BAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAceptar.Location = new System.Drawing.Point(222, 138);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(82, 32);
            this.BAceptar.TabIndex = 1;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCAncelar
            // 
            this.BCAncelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCAncelar.Image = ((System.Drawing.Image)(resources.GetObject("BCAncelar.Image")));
            this.BCAncelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCAncelar.Location = new System.Drawing.Point(318, 138);
            this.BCAncelar.Name = "BCAncelar";
            this.BCAncelar.Size = new System.Drawing.Size(82, 32);
            this.BCAncelar.TabIndex = 2;
            this.BCAncelar.Text = "Cancelar";
            this.BCAncelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCAncelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar";
            // 
            // TUsuario
            // 
            this.TUsuario.Location = new System.Drawing.Point(270, 29);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(130, 20);
            this.TUsuario.TabIndex = 6;
            // 
            // TContrseña
            // 
            this.TContrseña.Location = new System.Drawing.Point(270, 57);
            this.TContrseña.Name = "TContrseña";
            this.TContrseña.PasswordChar = '*';
            this.TContrseña.Size = new System.Drawing.Size(130, 20);
            this.TContrseña.TabIndex = 7;
            // 
            // TContraseña2
            // 
            this.TContraseña2.Location = new System.Drawing.Point(270, 92);
            this.TContraseña2.Name = "TContraseña2";
            this.TContraseña2.PasswordChar = '*';
            this.TContraseña2.Size = new System.Drawing.Size(130, 20);
            this.TContraseña2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "contraseña";
            // 
            // controladorValidador1
            // 
            this.controladorValidador1.Boton = this.BAceptar;
            this.controladorValidador1.Enabled = true;
            this.controladorValidador1.OnValidar += new Validador.OnEnableBotonEvent(this.controladorValidador1_OnValidar);
            // 
            // cTextoRequerido1
            // 
            this.cTextoRequerido1.ModoValidacion = Validador.ValidateMode.NINGUNO;
            this.cTextoRequerido1.TextBox = this.TUsuario;
            this.cTextoRequerido1.Validador = this.controladorValidador1;
            // 
            // cTextoRequerido2
            // 
            this.cTextoRequerido2.ModoValidacion = Validador.ValidateMode.NINGUNO;
            this.cTextoRequerido2.TextBox = this.TContrseña;
            this.cTextoRequerido2.Validador = this.controladorValidador1;
            // 
            // cTextoRequerido3
            // 
            this.cTextoRequerido3.ModoValidacion = Validador.ValidateMode.NINGUNO;
            this.cTextoRequerido3.TextBox = this.TContraseña2;
            this.cTextoRequerido3.Validador = this.controladorValidador1;
            // 
            // RegPassword
            // 
            this.RegPassword.Clave = "Password";
            this.RegPassword.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.RegPassword.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS";
            // 
            // RegUsuario
            // 
            this.RegUsuario.Clave = "Usuario";
            this.RegUsuario.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.RegUsuario.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS";
            // 
            // RegKey
            // 
            this.RegKey.Clave = "Key";
            this.RegKey.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.RegKey.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS";
            // 
            // FormRegPassword
            // 
            this.AcceptButton = this.BAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCAncelar;
            this.ClientSize = new System.Drawing.Size(421, 182);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TContraseña2);
            this.Controls.Add(this.TContrseña);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCAncelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCAncelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.TextBox TContrseña;
        private System.Windows.Forms.TextBox TContraseña2;
        private System.Windows.Forms.Label label4;
        private Validador.ControladorValidador controladorValidador1;
        private Validador.CTextoRequerido cTextoRequerido1;
        private Validador.CTextoRequerido cTextoRequerido2;
        private Validador.CTextoRequerido cTextoRequerido3;
        private DialogConecSQL2005.WinReg RegPassword;
        private DialogConecSQL2005.WinReg RegUsuario;
        private DialogConecSQL2005.WinReg RegKey;
    }
}