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
namespace Bakup_SQLExpress
{
    public partial class FormPassword : Form
    {
        string xmlKey;
        byte[] bytString, bytEncriptar, bytDesEncriptar;
        public FormPassword()
        {
            InitializeComponent();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            string s;            
            bool ok = true;
            if (Desencriptar(RegPassword.Valor) != TContrseña.Text)
                ok = false;
            if (RegUsuario.Valor != TUsuario.Text)
                ok = false;
            if (ok == false)
            {
                MessageBox.Show("Clave de usuario o contraseña incorrecta", "Cerrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }
        }
        private string  encriptar(string EncriptString)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            RSACryptoServiceProvider sec = new RSACryptoServiceProvider();
            byte[] bytString, bytEncriptar, bytDesEncriptar;
            string strEncriptar = "";
            if (EncriptString != "")
            {
                try
                {
                    xmlKey = sec.ToXmlString(true);
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
        public string Desencriptar(string TextEncripted)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            RSACryptoServiceProvider sec = new RSACryptoServiceProvider();
            string strDesencriptar = "";
            if (TextEncripted != "")
            {
                try
                {
                    sec.FromXmlString(RegKey.Valor);
                    byte[] b = Convert.FromBase64String(TextEncripted);
                    bytDesEncriptar = sec.Decrypt(b, false);
                    strDesencriptar = ue.GetString(bytDesEncriptar);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("No se realizo la Desencripción " + ex.Message, "...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return strDesencriptar;
        }
    }
}
