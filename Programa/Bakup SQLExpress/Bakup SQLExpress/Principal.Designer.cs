namespace Bakup_SQLExpress
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarJuntoConWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarJuntoConWindowsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMensajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegUsuario = new DialogConecSQL2005.WinReg(this.components);
            this.RegPassword = new DialogConecSQL2005.WinReg(this.components);
            this.RegIni = new DialogConecSQL2005.WinReg(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BAkup SQL Express";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.iniciarJuntoConWindowsToolStripMenuItem,
            this.iniciarJuntoConWindowsToolStripMenuItem1,
            this.cambiarContraseñaToolStripMenuItem,
            this.verMensajesToolStripMenuItem,
            this.licenciaToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 158);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tareasToolStripMenuItem.Image")));
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.tareasToolStripMenuItem.Text = "Tareas";
            this.tareasToolStripMenuItem.Click += new System.EventHandler(this.tareasToolStripMenuItem_Click);
            // 
            // iniciarJuntoConWindowsToolStripMenuItem
            // 
            this.iniciarJuntoConWindowsToolStripMenuItem.Checked = true;
            this.iniciarJuntoConWindowsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iniciarJuntoConWindowsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iniciarJuntoConWindowsToolStripMenuItem.Image")));
            this.iniciarJuntoConWindowsToolStripMenuItem.Name = "iniciarJuntoConWindowsToolStripMenuItem";
            this.iniciarJuntoConWindowsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.iniciarJuntoConWindowsToolStripMenuItem.Text = "Iniciar junto con Windows";
            this.iniciarJuntoConWindowsToolStripMenuItem.Visible = false;
            this.iniciarJuntoConWindowsToolStripMenuItem.Click += new System.EventHandler(this.iniciarJuntoConWindowsToolStripMenuItem_Click);
            // 
            // iniciarJuntoConWindowsToolStripMenuItem1
            // 
            this.iniciarJuntoConWindowsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("iniciarJuntoConWindowsToolStripMenuItem1.Image")));
            this.iniciarJuntoConWindowsToolStripMenuItem1.Name = "iniciarJuntoConWindowsToolStripMenuItem1";
            this.iniciarJuntoConWindowsToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.iniciarJuntoConWindowsToolStripMenuItem1.Text = "Iniciar junto con Windows";
            this.iniciarJuntoConWindowsToolStripMenuItem1.Click += new System.EventHandler(this.iniciarJuntoConWindowsToolStripMenuItem1_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarContraseñaToolStripMenuItem.Image")));
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // verMensajesToolStripMenuItem
            // 
            this.verMensajesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verMensajesToolStripMenuItem.Image")));
            this.verMensajesToolStripMenuItem.Name = "verMensajesToolStripMenuItem";
            this.verMensajesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.verMensajesToolStripMenuItem.Text = "Ver mensajes";
            this.verMensajesToolStripMenuItem.Click += new System.EventHandler(this.verMensajesToolStripMenuItem_Click);
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licenciaToolStripMenuItem.Image")));
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.licenciaToolStripMenuItem.Text = "Licencia";
            this.licenciaToolStripMenuItem.Click += new System.EventHandler(this.licenciaToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarToolStripMenuItem.Image")));
            this.cerrarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // RegUsuario
            // 
            this.RegUsuario.Clave = "Usuario";
            this.RegUsuario.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.RegUsuario.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS";
            // 
            // RegPassword
            // 
            this.RegPassword.Clave = "Password";
            this.RegPassword.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.RegPassword.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS";
            // 
            // RegIni
            // 
            this.RegIni.Clave = "BakupSQL";
            this.RegIni.Key = DialogConecSQL2005.KEYS.LocalMachine;
            this.RegIni.SubKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 297);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private DialogConecSQL2005.WinReg RegUsuario;
        private DialogConecSQL2005.WinReg RegPassword;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarJuntoConWindowsToolStripMenuItem;
        private DialogConecSQL2005.WinReg RegIni;
        private System.Windows.Forms.ToolStripMenuItem iniciarJuntoConWindowsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verMensajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
    }
}

