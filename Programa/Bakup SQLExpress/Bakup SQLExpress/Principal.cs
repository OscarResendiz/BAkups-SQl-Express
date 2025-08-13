using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Bakup_SQLExpress
{
    public partial class Principal : Form
    {
        FormTareas Tareas;
        private bool InicioOK;
        public Principal()
        {
            InicioOK = true;
            string s = "";
            try
            {
                InitializeComponent();
                s = RegIni.Valor;
            }
            catch (System.Exception)
            {
                InicioOK = false;
                MessageBox.Show("Se requieren permisos de administrador");
                return;
            }
            Tareas = new FormTareas();
            if (s == null || s == "")
            {
                //no esta activo
                iniciarJuntoConWindowsToolStripMenuItem.Visible = false;
                iniciarJuntoConWindowsToolStripMenuItem1.Visible = true;
            }
            else
            {
                iniciarJuntoConWindowsToolStripMenuItem.Visible = true;
                iniciarJuntoConWindowsToolStripMenuItem1.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (InicioOK == false)
                return;
            Visible = false;
            timer1.Enabled = false;
            //verifico la licencia
            FormLicencia licencia = new FormLicencia();
            if (licencia.ValidaLicencia() == false)
            {
                MessageBox.Show("Se requiere la licencia");
                if (licencia.ShowDialog() == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
            if (RegUsuario.Valor == "" || RegUsuario.Valor==null )
            {
                MessageBox.Show("Se requiere asigne  la contraseña del administrador");
                FormRegPassword dlg = new FormRegPassword();
                if (dlg.ShowDialog() == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
                //hay que preguntar si hay que iniciar junto con windows
                if (MessageBox.Show("¿Desea iniciar la aplicación junto con Windows?", "Ininciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    iniciarJuntoConWindowsToolStripMenuItem1_Click(null,null);
                }
            }
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar la aplicación", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;
            FormPassword dlg = new FormPassword();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (InicioOK == false)
                Close();
            MensajeError("Se inicio la aplicación");
        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tareas.Visible == false)
                Tareas.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPassword dlg = new FormPassword();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            FormRegPassword dlg2 = new FormRegPassword();
            dlg2.ShowDialog();
        }

        private void iniciarJuntoConWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPassword dlg = new FormPassword();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            string s = Application.ExecutablePath;
            iniciarJuntoConWindowsToolStripMenuItem.Visible = false;
            iniciarJuntoConWindowsToolStripMenuItem1.Visible = true;
            RegIni.setValor("");
        }
        private void iniciarJuntoConWindowsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //iniciar con windos
            FormPassword dlg = new FormPassword();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            string s = Application.ExecutablePath;
            iniciarJuntoConWindowsToolStripMenuItem.Visible = true;
            iniciarJuntoConWindowsToolStripMenuItem1.Visible = false;
            RegIni.setValor(s);
        }
        public static string DirectorioExcutable
        {
            get
            {
                string s = Application.ExecutablePath;// +"\\Canciones.txt";
                int i, n, ultimo = 0;
                n = s.Length;
                for (i = 0; i < n; i++)
                {
                    if (s[i] == '\\')
                        ultimo = i;
                }
                s = s.Substring(0, ultimo);
                return s + "\\";
            }
        }
        private void MensajeError(string msg)
        {
            //guarda un archivo con el registro de los errores generados
            string s = DirectorioExcutable + "Errores.txt";
            StreamWriter sw;
            sw = File.AppendText(s);
            sw.WriteLine(System.DateTime.Now.ToString()+"\t"+ msg);
            sw.Close();
        }

        private void verMensajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMensajes dlg=new FormMensajes();
            dlg.ShowDialog();
        }

        private void licenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLicencia dlg = new FormLicencia();
            dlg.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MensajeError("Se Cerro la aplicación");
        }
    }
}
