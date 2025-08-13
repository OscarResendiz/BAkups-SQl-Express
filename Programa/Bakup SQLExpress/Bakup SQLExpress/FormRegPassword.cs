using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Bakup_SQLExpress
{
    public partial class FormRegPassword : Form
    {
        string Key;
        public FormRegPassword()
        {
            InitializeComponent();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            RegPassword.setValor(encriptar(TContrseña.Text));
            RegUsuario.setValor(TUsuario.Text);
            RegKey.setValor(Key);
        }

        private void controladorValidador1_OnValidar(ref bool ok)
        {
            if (TContrseña.Text != TContraseña2.Text)
                ok = false;
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
                    Key = sec.ToXmlString(true);
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
    }
}
