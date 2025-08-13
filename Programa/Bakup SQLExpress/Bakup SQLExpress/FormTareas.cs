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
    public delegate void OnHoraEvent(int hora,int minuto,string horario,DayOfWeek dia);
    public partial class FormTareas : Form
    {
        private bool Respaldando;
        public event OnHoraEvent OnHora;
        private string Key;
        public FormTareas()
        {
            Respaldando = false;
            InitializeComponent();
            Cargatareas();
        }

        private void FormTareas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTareas_Load(object sender, EventArgs e)
        {

        }
        private void Cargatareas()
        {
            Microsoft.Win32.RegistryKey reg = null;
            try
            {
                reg = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\BAKUPSQLEXPRESS");
            }
            catch (System.Exception)
            {
                return;
            }
            string[] claves;
            claves = reg.GetSubKeyNames();
            foreach (string s in claves)
            {
                CTarea tarea = new CTarea();
                tmpKey.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS\\" + s;
                tmpKey.Clave = "ConnectionString";
                tarea.CadenaConexion = tmpKey.Valor;
                tmpKey.Clave = "Hora";
                tarea.Hora = tmpKey.Valor;
                tarea.Nombre = s;
                tmpKey.Clave = "Paht";
                tarea.Paht = tmpKey.Valor;
                tmpKey.Clave = "Key";
                tarea.Key = tmpKey.Valor;
                tmpKey.Clave = "Minutos";
                tarea.Minutos = tmpKey.Valor;
                tmpKey.Clave = "Horario";
                tarea.Horario = tmpKey.Valor;
                try
                {
                    tmpKey.Clave = "DBoDirectorio";
                    tarea.DBoDirectorio = bool.Parse(tmpKey.Valor);
                }
                catch (System.Exception)
                {
                    tarea.DBoDirectorio = true;
                }                
                try
                {
                    tmpKey.Clave = "Lunes";
                    tarea.Lunes = bool.Parse(tmpKey.Valor);
                }
                catch (System.Exception)
                {
                    tarea.Lunes = false;
                }
                try
                {
                    tmpKey.Clave = "Martes";
                    tarea.Martes = bool.Parse(tmpKey.Valor);
                }
                catch (System.Exception)
                {
                    tarea.Martes = false;
                }
                try
                {
                    tmpKey.Clave = "Miércoles";
                    tarea.Miércoles = bool.Parse(tmpKey.Valor);
                }
                catch (System.Exception)
                {
                    tarea.Miércoles = false;
                }
                try
                {
                    tmpKey.Clave = "Jueves";
                    tarea.Jueves = bool.Parse(tmpKey.Valor);
                }
                catch (System.Exception)
                {
                    tarea.Jueves = false;
                }
                try
                {
                    tmpKey.Clave = "Viernes";
                    tarea.Viernes = bool.Parse(tmpKey.Valor);
                }
                catch (System.Exception)
                {
                    tarea.Viernes = false;
                }
                try
                {
                    tmpKey.Clave = "Sábado";
                    tarea.Sábado = bool.Parse(tmpKey.Valor);
                }
                catch (System.Exception)
                {
                    tarea.Sábado = false;
                }
                try
                {
                    tmpKey.Clave = "Domingo";
                    tarea.Domingo = bool.Parse(tmpKey.Valor);
                }
                catch (System.Exception)
                {
                    tarea.Domingo = false;
                }
                AgregaTarea(tarea);
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            FormTarea dlg = new FormTarea();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            //verifico si no esta repetido el nombre

            foreach (CTarea obj in ListaTareas.Items)
            {
                if (obj.Nombre == dlg.Nombre)
                {
                    MessageBox.Show("Ya existe la tarea");
                    return;
                }
            }
            //no existe, por lo que lo agrego
            CTarea tarea=new CTarea();
            tarea.CadenaConexion = encriptar(dlg.ConnectionString);
            tarea.Hora = dlg.Hora;
            tarea.Nombre=dlg.Nombre;
            tarea.Paht = dlg.Paht;
            tarea.Key = Key;
            tarea.Minutos=dlg.Minutos;
            tarea.Horario =dlg.Horario;
            tarea.Lunes = dlg.Lunes;
            tarea.Martes = dlg.Martes;
            tarea.Miércoles = dlg.Miércoles;
            tarea.Jueves = dlg.Jueves;
            tarea.Viernes = dlg.Viernes;
            tarea.Sábado = dlg.Sábado;
            tarea.Domingo = dlg.Domingo;
            tarea.DBoDirectorio = dlg.DBoDirectorio;
            tmpKey.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS\\" + tarea.Nombre;
            tmpKey.Clave = "Paht";
            tmpKey.setValor(tarea.Paht);
            tmpKey.Clave = "ConnectionString";
            tmpKey.setValor(tarea.CadenaConexion);
            tmpKey.Clave = "Hora";
            tmpKey.setValor(tarea.Hora);
            tmpKey.Clave = "Key";
            tmpKey.setValor(tarea.Key);
            tmpKey.Clave = "Minutos";
            tmpKey.setValor(tarea.Minutos);
            tmpKey.Clave = "Horario";
            tmpKey.setValor(tarea.Horario );
            tmpKey.Clave = "Lunes";
            tmpKey.setValor(tarea.Lunes.ToString());
            tmpKey.Clave = "Martes";
            tmpKey.setValor(tarea.Martes.ToString());
            tmpKey.Clave = "Miércoles";
            tmpKey.setValor(tarea.Miércoles.ToString());
            tmpKey.Clave = "Jueves";
            tmpKey.setValor(tarea.Jueves.ToString());
            tmpKey.Clave = "Viernes";
            tmpKey.setValor(tarea.Viernes.ToString());
            tmpKey.Clave = "Sábado";
            tmpKey.setValor(tarea.Sábado.ToString());
            tmpKey.Clave = "Domingo";
            tmpKey.setValor(tarea.Domingo.ToString());
            tmpKey.Clave = "DBoDirectorio";
            tmpKey.setValor(tarea.DBoDirectorio.ToString());
            AgregaTarea(tarea);
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
                    MensajeError("No se realizo la encripción " + ex.Message);
                }
            }
            return strEncriptar;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            CTarea obj;
            obj=(CTarea)ListaTareas.Items[ListaTareas.SelectedIndex];
            //elimino el registro
            Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\BAKUPSQLEXPRESS\\");
            reg.DeleteSubKey(obj.Nombre);
            OnHora -= new OnHoraEvent(obj.OnHora);
            ListaTareas.Items.Remove(obj);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hora,minutos;
            string horario="AM";
            hora = System.DateTime.Now.Hour;
            minutos = System.DateTime.Now.Minute;
            if (hora >= 12)
            {
                horario = "PM";
                hora = hora - 12;
            }            
            if(OnHora!=null)                
                OnHora(hora, minutos, horario,System.DateTime.Now.DayOfWeek);
        }
        private void AgregaTarea(CTarea obj)
        {
            OnHora += new OnHoraEvent(obj.OnHora);
            ListaTareas.Items.Add(obj);
        }

        private void ListaTareas_DoubleClick(object sender, EventArgs e)
        {
            if (ListaTareas.SelectedIndex == -1)
                return;
            CTarea tarea = (CTarea)ListaTareas.Items[ListaTareas.SelectedIndex];
            //muestro el dialogo
            FormTarea dlg = new FormTarea();
            dlg.ConnectionString = Desencriptar(tarea.CadenaConexion, tarea.Key);
            dlg.Hora = tarea.Hora;
            dlg.Nombre=tarea.Nombre ;
            dlg.Paht=tarea.Paht ;
            dlg.Minutos=tarea.Minutos ;
            dlg.Horario=tarea.Horario;

            dlg.Lunes = tarea.Lunes;
            dlg.Martes = tarea.Martes;
            dlg.Miércoles = tarea.Miércoles;
            dlg.Jueves = tarea.Jueves;
            dlg.Viernes = tarea.Viernes;
            dlg.Sábado = tarea.Sábado;
            dlg.Domingo = tarea.Domingo;
            dlg.DBoDirectorio = tarea.DBoDirectorio;
            tarea.OnEsatus += new OnEsatusEvent(dlg.Mensaje);
            dlg.Mensaje(tarea.Estatus);
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            //actualizo los datos
            tarea.CadenaConexion = encriptar(dlg.ConnectionString);
            tarea.Hora = dlg.Hora;
            tarea.Nombre = dlg.Nombre;
            tarea.Paht = dlg.Paht;
            tarea.Key = Key;
            tarea.Minutos = dlg.Minutos;
            tarea.Horario = dlg.Horario;

            tarea.Lunes = dlg.Lunes;
            tarea.Martes = dlg.Martes;
            tarea.Miércoles = dlg.Miércoles;
            tarea.Jueves = dlg.Jueves;
            tarea.Viernes = dlg.Viernes;
            tarea.Sábado = dlg.Sábado;
            tarea.Domingo = dlg.Domingo;
            tarea.DBoDirectorio = dlg.DBoDirectorio;
            
            tmpKey.SubKey = "SOFTWARE\\BAKUPSQLEXPRESS\\" + tarea.Nombre;
            tmpKey.Clave = "Paht";
            tmpKey.setValor(tarea.Paht);

            tmpKey.Clave = "ConnectionString";
            tmpKey.setValor(tarea.CadenaConexion);

            tmpKey.Clave = "Hora";
            tmpKey.setValor(tarea.Hora);

            tmpKey.Clave = "Key";
            tmpKey.setValor(tarea.Key);

            tmpKey.Clave = "Minutos";
            tmpKey.setValor(tarea.Minutos);

            tmpKey.Clave = "Horario";
            tmpKey.setValor(tarea.Horario);

            tmpKey.Clave = "Lunes";
            tmpKey.setValor(tarea.Lunes.ToString());

            tmpKey.Clave = "Martes";
            tmpKey.setValor(tarea.Martes.ToString());

            tmpKey.Clave = "Miércoles";
            tmpKey.setValor(tarea.Miércoles.ToString());

            tmpKey.Clave = "Jueves";
            tmpKey.setValor(tarea.Jueves.ToString());

            tmpKey.Clave = "Viernes";
            tmpKey.setValor(tarea.Viernes.ToString());

            tmpKey.Clave = "Sábado";
            tmpKey.setValor(tarea.Sábado.ToString());

            tmpKey.Clave = "Domingo";
            tmpKey.setValor(tarea.Domingo.ToString());
            tmpKey.Clave = "DBoDirectorio";
            tmpKey.setValor(tarea.DBoDirectorio.ToString());
            
        }
        public string Desencriptar(string TextEncripted,string Key)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            RSACryptoServiceProvider sec = new RSACryptoServiceProvider();
            string strDesencriptar = "";
            if (TextEncripted != "")
            {
                try
                {
                    sec.FromXmlString(Key);
                    byte[] b = Convert.FromBase64String(TextEncripted);
                    byte[] bytDesEncriptar = sec.Decrypt(b, false);
                    strDesencriptar = ue.GetString(bytDesEncriptar);
                }
                catch (System.Exception ex)
                {
                    MensajeError("No se realizo la Desencripción " + ex.Message);
                }
            }
            return strDesencriptar;
        }
        private void MensajeError(string msg)
        {
            //guarda un archivo con el registro de los errores generados
            string s = Principal.DirectorioExcutable + "Errores.txt";
            StreamWriter sw;
            sw = File.AppendText(s);
            sw.WriteLine(System.DateTime.Now.ToString() + "\t" + msg);
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imagen.Visible = true;
            Respaldando = true;
            CTarea obj;
            obj = (CTarea)ListaTareas.Items[ListaTareas.SelectedIndex];
            obj.OnFinProceso += new OnFinProcesoEvent(OnFinProcesoEvent);
            if (obj.DBoDirectorio == true)
                obj.CreaRespaldoDB();
            else
                obj.RespaldaDirectorio();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bool ok = true;
            if (ListaTareas.SelectedIndex == -1)
                ok = false;
            BEliminar.Enabled = ok;
            if (Respaldando == true)
            {
                if(            Imagen.Visible != true)
                    Imagen.Visible = true;

                ok = false;
            }
            else
            {
                if (Imagen.Visible != false)
                    Imagen.Visible = false;
            }
            BBakup.Enabled = ok;
        }
        private void OnFinProcesoEvent(CTarea obj)
        {
            MessageBox.Show("Se finalizo el respaldo de la base de datos "+obj.Nombre);
            obj.OnFinProceso -= new OnFinProcesoEvent(OnFinProcesoEvent);
            Respaldando = false;
        }
    }
}
