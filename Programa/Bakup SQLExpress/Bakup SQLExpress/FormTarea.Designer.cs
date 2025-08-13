namespace Bakup_SQLExpress
{
    partial class FormTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarea));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TPaht = new System.Windows.Forms.TextBox();
            this.TConexion = new System.Windows.Forms.TextBox();
            this.BCAncelar = new System.Windows.Forms.Button();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BBase = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.controladorValidador1 = new Validador.ControladorValidador(this.components);
            this.cTextoRequerido1 = new Validador.CTextoRequerido(this.components);
            this.cTextoRequerido2 = new Validador.CTextoRequerido(this.components);
            this.cTextoRequerido3 = new Validador.CTextoRequerido(this.components);
            this.dialogConecSQL20051 = new DialogConecSQL2005.DialogConecSQL2005(this.components);
            this.ComboHora = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboMinuto = new System.Windows.Forms.ComboBox();
            this.ComboHorario = new System.Windows.Forms.ComboBox();
            this.cValidaComboBox1 = new Validador.CValidaComboBox(this.components);
            this.cValidaComboBox2 = new Validador.CValidaComboBox(this.components);
            this.cValidaComboBox3 = new Validador.CValidaComboBox(this.components);
            this.CHLunes = new System.Windows.Forms.CheckBox();
            this.CHMartes = new System.Windows.Forms.CheckBox();
            this.CHMiércoles = new System.Windows.Forms.CheckBox();
            this.CHJueves = new System.Windows.Forms.CheckBox();
            this.CHViernes = new System.Windows.Forms.CheckBox();
            this.CHSábado = new System.Windows.Forms.CheckBox();
            this.CHDomingo = new System.Windows.Forms.CheckBox();
            this.RBDB = new System.Windows.Forms.RadioButton();
            this.RBDirectorio = new System.Windows.Forms.RadioButton();
            this.BBuscar2 = new System.Windows.Forms.Button();
            this.LMensaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Directorio destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cadena de conexión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(303, 6);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(175, 20);
            this.TNombre.TabIndex = 5;
            // 
            // TPaht
            // 
            this.TPaht.Location = new System.Drawing.Point(348, 65);
            this.TPaht.Name = "TPaht";
            this.TPaht.Size = new System.Drawing.Size(130, 20);
            this.TPaht.TabIndex = 6;
            // 
            // TConexion
            // 
            this.TConexion.Location = new System.Drawing.Point(364, 99);
            this.TConexion.Name = "TConexion";
            this.TConexion.PasswordChar = '*';
            this.TConexion.ReadOnly = true;
            this.TConexion.Size = new System.Drawing.Size(114, 20);
            this.TConexion.TabIndex = 7;
            // 
            // BCAncelar
            // 
            this.BCAncelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCAncelar.Image = ((System.Drawing.Image)(resources.GetObject("BCAncelar.Image")));
            this.BCAncelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCAncelar.Location = new System.Drawing.Point(382, 223);
            this.BCAncelar.Name = "BCAncelar";
            this.BCAncelar.Size = new System.Drawing.Size(82, 32);
            this.BCAncelar.TabIndex = 10;
            this.BCAncelar.Text = "Cancelar";
            this.BCAncelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCAncelar.UseVisualStyleBackColor = true;
            // 
            // BAceptar
            // 
            this.BAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BAceptar.Image")));
            this.BAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAceptar.Location = new System.Drawing.Point(259, 223);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(82, 32);
            this.BAceptar.TabIndex = 9;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAceptar.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            this.BBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar.Image")));
            this.BBuscar.Location = new System.Drawing.Point(484, 51);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(41, 34);
            this.BBuscar.TabIndex = 11;
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // BBase
            // 
            this.BBase.Image = ((System.Drawing.Image)(resources.GetObject("BBase.Image")));
            this.BBase.Location = new System.Drawing.Point(484, 91);
            this.BBase.Name = "BBase";
            this.BBase.Size = new System.Drawing.Size(41, 39);
            this.BBase.TabIndex = 12;
            this.BBase.UseVisualStyleBackColor = true;
            this.BBase.Click += new System.EventHandler(this.BBase_Click);
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
            this.cTextoRequerido1.TextBox = this.TConexion;
            this.cTextoRequerido1.Validador = this.controladorValidador1;
            // 
            // cTextoRequerido2
            // 
            this.cTextoRequerido2.ModoValidacion = Validador.ValidateMode.NINGUNO;
            this.cTextoRequerido2.TextBox = this.TNombre;
            this.cTextoRequerido2.Validador = this.controladorValidador1;
            // 
            // cTextoRequerido3
            // 
            this.cTextoRequerido3.ModoValidacion = Validador.ValidateMode.NINGUNO;
            this.cTextoRequerido3.TextBox = this.TPaht;
            this.cTextoRequerido3.Validador = this.controladorValidador1;
            // 
            // dialogConecSQL20051
            // 
            this.dialogConecSQL20051.ConnectionString = null;
            // 
            // ComboHora
            // 
            this.ComboHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboHora.FormattingEnabled = true;
            this.ComboHora.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.ComboHora.Location = new System.Drawing.Point(289, 134);
            this.ComboHora.Name = "ComboHora";
            this.ComboHora.Size = new System.Drawing.Size(69, 21);
            this.ComboHora.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // ComboMinuto
            // 
            this.ComboMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMinuto.FormattingEnabled = true;
            this.ComboMinuto.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.ComboMinuto.Location = new System.Drawing.Point(380, 134);
            this.ComboMinuto.Name = "ComboMinuto";
            this.ComboMinuto.Size = new System.Drawing.Size(69, 21);
            this.ComboMinuto.TabIndex = 15;
            // 
            // ComboHorario
            // 
            this.ComboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboHorario.FormattingEnabled = true;
            this.ComboHorario.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.ComboHorario.Location = new System.Drawing.Point(456, 134);
            this.ComboHorario.Name = "ComboHorario";
            this.ComboHorario.Size = new System.Drawing.Size(69, 21);
            this.ComboHorario.TabIndex = 16;
            // 
            // cValidaComboBox1
            // 
            this.cValidaComboBox1.Combo = this.ComboHora;
            this.cValidaComboBox1.Validador = this.controladorValidador1;
            // 
            // cValidaComboBox2
            // 
            this.cValidaComboBox2.Combo = this.ComboHorario;
            this.cValidaComboBox2.Validador = this.controladorValidador1;
            // 
            // cValidaComboBox3
            // 
            this.cValidaComboBox3.Combo = this.ComboMinuto;
            this.cValidaComboBox3.Validador = this.controladorValidador1;
            // 
            // CHLunes
            // 
            this.CHLunes.AutoSize = true;
            this.CHLunes.Location = new System.Drawing.Point(256, 172);
            this.CHLunes.Name = "CHLunes";
            this.CHLunes.Size = new System.Drawing.Size(55, 17);
            this.CHLunes.TabIndex = 17;
            this.CHLunes.Text = "Lunes";
            this.CHLunes.UseVisualStyleBackColor = true;
            // 
            // CHMartes
            // 
            this.CHMartes.AutoSize = true;
            this.CHMartes.Location = new System.Drawing.Point(317, 172);
            this.CHMartes.Name = "CHMartes";
            this.CHMartes.Size = new System.Drawing.Size(58, 17);
            this.CHMartes.TabIndex = 18;
            this.CHMartes.Text = "Martes";
            this.CHMartes.UseVisualStyleBackColor = true;
            // 
            // CHMiércoles
            // 
            this.CHMiércoles.AutoSize = true;
            this.CHMiércoles.Location = new System.Drawing.Point(380, 172);
            this.CHMiércoles.Name = "CHMiércoles";
            this.CHMiércoles.Size = new System.Drawing.Size(71, 17);
            this.CHMiércoles.TabIndex = 19;
            this.CHMiércoles.Text = "Miércoles";
            this.CHMiércoles.UseVisualStyleBackColor = true;
            // 
            // CHJueves
            // 
            this.CHJueves.AutoSize = true;
            this.CHJueves.Location = new System.Drawing.Point(456, 172);
            this.CHJueves.Name = "CHJueves";
            this.CHJueves.Size = new System.Drawing.Size(60, 17);
            this.CHJueves.TabIndex = 20;
            this.CHJueves.Text = "Jueves";
            this.CHJueves.UseVisualStyleBackColor = true;
            // 
            // CHViernes
            // 
            this.CHViernes.AutoSize = true;
            this.CHViernes.Location = new System.Drawing.Point(256, 197);
            this.CHViernes.Name = "CHViernes";
            this.CHViernes.Size = new System.Drawing.Size(61, 17);
            this.CHViernes.TabIndex = 21;
            this.CHViernes.Text = "Viernes";
            this.CHViernes.UseVisualStyleBackColor = true;
            // 
            // CHSábado
            // 
            this.CHSábado.AutoSize = true;
            this.CHSábado.Location = new System.Drawing.Point(317, 195);
            this.CHSábado.Name = "CHSábado";
            this.CHSábado.Size = new System.Drawing.Size(63, 17);
            this.CHSábado.TabIndex = 22;
            this.CHSábado.Text = "Sábado";
            this.CHSábado.UseVisualStyleBackColor = true;
            // 
            // CHDomingo
            // 
            this.CHDomingo.AutoSize = true;
            this.CHDomingo.Location = new System.Drawing.Point(380, 197);
            this.CHDomingo.Name = "CHDomingo";
            this.CHDomingo.Size = new System.Drawing.Size(68, 17);
            this.CHDomingo.TabIndex = 23;
            this.CHDomingo.Text = "Domingo";
            this.CHDomingo.UseVisualStyleBackColor = true;
            // 
            // RBDB
            // 
            this.RBDB.AutoSize = true;
            this.RBDB.Checked = true;
            this.RBDB.Location = new System.Drawing.Point(255, 32);
            this.RBDB.Name = "RBDB";
            this.RBDB.Size = new System.Drawing.Size(93, 17);
            this.RBDB.TabIndex = 24;
            this.RBDB.TabStop = true;
            this.RBDB.Text = "Base de datos";
            this.RBDB.UseVisualStyleBackColor = true;
            this.RBDB.CheckedChanged += new System.EventHandler(this.RBDB_CheckedChanged);
            // 
            // RBDirectorio
            // 
            this.RBDirectorio.AutoSize = true;
            this.RBDirectorio.Location = new System.Drawing.Point(367, 32);
            this.RBDirectorio.Name = "RBDirectorio";
            this.RBDirectorio.Size = new System.Drawing.Size(70, 17);
            this.RBDirectorio.TabIndex = 25;
            this.RBDirectorio.Text = "Directorio";
            this.RBDirectorio.UseVisualStyleBackColor = true;
            // 
            // BBuscar2
            // 
            this.BBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar2.Image")));
            this.BBuscar2.Location = new System.Drawing.Point(484, 94);
            this.BBuscar2.Name = "BBuscar2";
            this.BBuscar2.Size = new System.Drawing.Size(41, 34);
            this.BBuscar2.TabIndex = 26;
            this.BBuscar2.UseVisualStyleBackColor = true;
            this.BBuscar2.Visible = false;
            this.BBuscar2.Click += new System.EventHandler(this.BBuscar2_Click);
            // 
            // LMensaje
            // 
            this.LMensaje.Location = new System.Drawing.Point(248, 261);
            this.LMensaje.Multiline = true;
            this.LMensaje.Name = "LMensaje";
            this.LMensaje.ReadOnly = true;
            this.LMensaje.Size = new System.Drawing.Size(285, 40);
            this.LMensaje.TabIndex = 28;
            // 
            // FormTarea
            // 
            this.AcceptButton = this.BAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCAncelar;
            this.ClientSize = new System.Drawing.Size(529, 301);
            this.ControlBox = false;
            this.Controls.Add(this.LMensaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BBuscar2);
            this.Controls.Add(this.RBDirectorio);
            this.Controls.Add(this.RBDB);
            this.Controls.Add(this.CHDomingo);
            this.Controls.Add(this.CHSábado);
            this.Controls.Add(this.CHViernes);
            this.Controls.Add(this.CHJueves);
            this.Controls.Add(this.CHMiércoles);
            this.Controls.Add(this.CHMartes);
            this.Controls.Add(this.CHLunes);
            this.Controls.Add(this.ComboHorario);
            this.Controls.Add(this.ComboMinuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboHora);
            this.Controls.Add(this.BBase);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BCAncelar);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.TConexion);
            this.Controls.Add(this.TPaht);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTarea";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TPaht;
        private System.Windows.Forms.TextBox TConexion;
        private System.Windows.Forms.Button BCAncelar;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BBase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Validador.ControladorValidador controladorValidador1;
        private Validador.CTextoRequerido cTextoRequerido1;
        private Validador.CTextoRequerido cTextoRequerido2;
        private Validador.CTextoRequerido cTextoRequerido3;
        private DialogConecSQL2005.DialogConecSQL2005 dialogConecSQL20051;
        private System.Windows.Forms.ComboBox ComboHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboMinuto;
        private System.Windows.Forms.ComboBox ComboHorario;
        private Validador.CValidaComboBox cValidaComboBox1;
        private Validador.CValidaComboBox cValidaComboBox2;
        private Validador.CValidaComboBox cValidaComboBox3;
        private System.Windows.Forms.CheckBox CHLunes;
        private System.Windows.Forms.CheckBox CHMartes;
        private System.Windows.Forms.CheckBox CHMiércoles;
        private System.Windows.Forms.CheckBox CHJueves;
        private System.Windows.Forms.CheckBox CHViernes;
        private System.Windows.Forms.CheckBox CHSábado;
        private System.Windows.Forms.CheckBox CHDomingo;
        private System.Windows.Forms.RadioButton RBDB;
        private System.Windows.Forms.RadioButton RBDirectorio;
        private System.Windows.Forms.Button BBuscar2;
        private System.Windows.Forms.TextBox LMensaje;
    }
}