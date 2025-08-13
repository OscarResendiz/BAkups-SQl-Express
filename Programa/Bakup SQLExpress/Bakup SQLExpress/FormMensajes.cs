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
    public partial class FormMensajes : Form
    {
        public FormMensajes()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = Principal.DirectorioExcutable + "Errores.txt";
            System.IO.File.Delete(s);
        }

        private void FormMensajes_Load(object sender, EventArgs e)
        {
            StreamReader sr;
            string s = Principal.DirectorioExcutable + "Errores.txt";
            if (!System.IO.File.Exists(s))
                return;
            sr = System.IO.File.OpenText(s);
            while (sr.Peek() != -1)
            {
                s = sr.ReadLine();
                if(s!=null)
                    listBox1.Items.Add(s);
            }
            sr.Close();
        }
    }
}
