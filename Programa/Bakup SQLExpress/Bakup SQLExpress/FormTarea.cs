using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bakup_SQLExpress
{
    public partial class FormTarea : Form
    {
        private string msg;
        public FormTarea()
        {
            InitializeComponent();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            TPaht.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BBase_Click(object sender, EventArgs e)
        {
            dialogConecSQL20051.ConnectionString = TConexion.Text;
            if (dialogConecSQL20051.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            TConexion.Text = dialogConecSQL20051.ConnectionString;

        }
        public string Nombre
        {
            set
            {
                TNombre.Text = value;
                TNombre.ReadOnly = true;
            }
            get
            {
                return TNombre.Text;
            }
        }
        public string Paht
        {
            get
            {
                return TPaht.Text;
            }
            set
            {
                TPaht.Text = value;
            }
        }
        public string ConnectionString
        {
            get
            {
                return TConexion.Text;
            }
            set
            {
                TConexion.Text = value;
            }
        }
        public string Hora
        {
            set
            {
                int h = int.Parse(value);
                int i, n;
                n = ComboHora.Items.Count;
                for (i = 0; i < n; i++)
                {

                    int h2 = int.Parse(ComboHora.Items[i].ToString());
                    if (h == h2)
                    {
                        ComboHora.SelectedIndex = i;
                        return;
                    }
                }
            }
            get
            {
                return ComboHora.Items[ComboHora.SelectedIndex].ToString();
            }
        }
        public string Minutos
        {
            set
            {
                int h = int.Parse(value);
                int i, n;
                n = ComboMinuto.Items.Count;
                for (i = 0; i < n; i++)
                {

                    int h2 = int.Parse(ComboMinuto.Items[i].ToString());
                    if (h == h2)
                    {
                        ComboMinuto.SelectedIndex = i;
                        return;
                    }
                }
            }
            get
            {
                return ComboMinuto.Items[ComboMinuto.SelectedIndex].ToString();
            }
        }
        public string Horario
        {
            set
            {
                int i, n;
                n = ComboHorario.Items.Count;
                for (i = 0; i < n; i++)
                {

                    string h2 = (string)ComboHorario.Items[i];
                    if (value == h2)
                    {
                        ComboHorario.SelectedIndex = i;
                        return;
                    }
                }
            }
            get
            {
                return ComboHorario.Items[ComboHorario.SelectedIndex].ToString();
            }
        }
        public bool Lunes
        {
            get
            {
                return CHLunes.Checked;
            }
            set
            {
                CHLunes.Checked = value;
            }
        }
        public bool Martes
        {
            get
            {
                return CHMartes.Checked;
            }
            set
            {
                CHMartes.Checked = value;
            }
        }
        public bool Miércoles
        {
            get
            {
                return CHMiércoles.Checked;
            }
            set
            {
                CHMiércoles.Checked = value;
            }
        }
        public bool Jueves
        {
            get
            {
                return CHJueves.Checked;
            }
            set
            {
                CHJueves.Checked = value;
            }
        }
        public bool Viernes
        {
            get
            {
                return CHViernes.Checked;
            }
            set
            {
                CHViernes.Checked = value;
            }
        }
        public bool Sábado
        {
            get
            {
                return CHSábado.Checked;
            }
            set
            {
                CHSábado.Checked = value;
            }
        }
        public bool Domingo
        {
            get
            {
                return CHDomingo.Checked;
            }
            set
            {
                CHDomingo.Checked = value;
            }
        }

        private void controladorValidador1_OnValidar(ref bool ok2)
        {
            LMensaje.Text = msg;
            bool ok = false;
            if (Lunes == true)
            {
                ok = true;
            }
            if (Martes == true)
            {
                ok = true;
            }
            if (Miércoles == true)
            {
                ok = true;
            }
            if (Jueves == true)
            {
                ok = true;
            }
            if (Viernes == true)
            {
                ok = true;
            }
            if (Sábado == true)
            {
                ok = true;
            }
            if (Domingo == true)
            {
                ok = true;
            }
            ok2 = ok;
        }

        private void BBuscar2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            TConexion.Text = folderBrowserDialog1.SelectedPath;
        }

        private void RBDB_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDB.Checked == true)
            {
                //es base de datos
                BBuscar2.Visible = false;
                BBase.Visible = true;
                label3.Text = "Cadena de conexión";
                TConexion.ReadOnly = true;
                TConexion.PasswordChar = '*';
            }
            else
            {
                //es directorio
                BBuscar2.Visible = true;
                BBase.Visible = false;
                label3.Text = "Directorio origen";
                TConexion.ReadOnly = false;
                TConexion.PasswordChar = '\0';
            }
        }
        public bool  DBoDirectorio
        {
            get
            {
                return RBDB.Checked;
            }
            set
            {
                RBDB.Checked = value;
                RBDirectorio.Checked = !value;
                RBDB.Enabled = false;
                RBDirectorio.Enabled = false;
                RBDB_CheckedChanged(null, null);
            }
        }
        public void Mensaje(string s)
        {
            msg = s;
        }
    }
}
