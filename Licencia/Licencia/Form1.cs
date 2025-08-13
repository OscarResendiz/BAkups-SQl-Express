using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Licencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string encriptar(string EncriptString)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            RSACryptoServiceProvider sec = new RSACryptoServiceProvider();
            byte[] bytString, bytEncriptar, bytDesEncriptar;
            string strEncriptar = "";
            if (EncriptString != "")
            {
                try
                {

                    TKey.Text = sec.ToXmlString(true);
                    bytString = ue.GetBytes(EncriptString);
                    bytEncriptar = sec.Encrypt(bytString, false);
                    strEncriptar = Convert.ToBase64String(bytEncriptar);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("No se realizo la encripción " + ex.Message, "...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return strEncriptar;
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            TClave.Text = encriptar(THHD.Text.Trim());
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
