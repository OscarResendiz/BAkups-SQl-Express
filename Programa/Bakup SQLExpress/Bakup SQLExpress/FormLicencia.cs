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


namespace Bakup_SQLExpress
{
    public partial class FormLicencia : Form
    {       
        public FormLicencia()
        {
            InitializeComponent();
        }
        private string HHDSrial
        {
            get
            {
                string s = "";
                int count = 0;
                DirectoryInfo currentDir = new DirectoryInfo(Environment.CurrentDirectory);
                string path = string.Format("win32_logicaldisk.deviceid=\"{0}\"",
                currentDir.Root.Name.Replace("\\", ""));
                ManagementObject disk = new ManagementObject(path);
                disk.Get();
                s=disk.Properties["VolumeSerialNumber"].Value.ToString();
                //foreach (PropertyData property in disk.Properties)
                //{
                //    string name = property.Name.PadRight(25);
                //    string value = (property.Value ?? string.Empty).ToString().PadRight(25);
                //    s=s+"Nombre: {"+name+"} Valor: {"+value+"}\n";
                //    //if ((++count % 10) == 0)
                //    //{
                //    //    break;
                //    //}
                //}
                //s=s+"Presione una tecla para terminar... ";
                return s;
            }
        }

        private void FormLicencia_Load(object sender, EventArgs e)
        {
            THHD.Text = HHDSrial;
            TClave.Text=RegLicencia.Valor;
            TKey.Text = RegLicenciaKey.Valor;
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

                    TKey .Text= sec.ToXmlString(true);
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

        private void button1_Click(object sender, EventArgs e)
        {
            TClave.Text=encriptar(THHD.Text.Trim());
        }

        public string Desencriptar(string TextEncripted,string key)
        {
            byte[] bytString, bytEncriptar, bytDesEncriptar;
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            RSACryptoServiceProvider sec = new RSACryptoServiceProvider();
            string strDesencriptar = "";
            if (TextEncripted != "")
            {
                try
                {
                    sec.FromXmlString(key);
                    byte[] b = Convert.FromBase64String(TextEncripted);
                    bytDesEncriptar = sec.Decrypt(b, false);
                    strDesencriptar = ue.GetString(bytDesEncriptar);
                }
                catch (System.Exception ex)
                {
                    return "";
                    //MessageBox.Show("No se realizo la Desencripción " + ex.Message, "...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return strDesencriptar;
        }
        private void BAceptar_Click(object sender, EventArgs e)
        {
            string s = Desencriptar(TClave.Text, TKey.Text);
            if (THHD.Text.Trim() != s)
            {
                MessageBox.Show("Clave no valida");
                return;
            }
            //guardo la clave
            RegLicencia.setValor(TClave.Text);
            RegLicenciaKey.setValor(TKey.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
        public bool ValidaLicencia()
        {
            //obtengo la clave del disco duro
            string s1,s2,s3;
            s1=RegLicencia.Valor;
            s2= RegLicenciaKey.Valor;
            s3=Desencriptar(s1, s2);
            if (HHDSrial != s3)
                return false;
            return true;
        }
    }
}
