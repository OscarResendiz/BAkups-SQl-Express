using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace Bakup_SQLExpress
{
    public delegate void ProcessingQuery();
    public delegate void OnFinProcesoEvent(CTarea obj);
    public delegate void OnEsatusEvent(string s);
    public class CTarea
    {
        public event OnEsatusEvent OnEsatus;
        private string Fstatus;
        public string Estatus
        {
            get
            {
                if (Fstatus == null)
                    Fstatus = "";
                return Fstatus;
            }
            set
            {
                Fstatus = value;
                if (OnEsatus != null)
                    OnEsatus(value);
            }
        }
        private List<string> Directorios;
        //private System.Windows.Forms.Timer TBuscar ;
        public event OnFinProcesoEvent OnFinProceso;
        private DateTime Inicio, Fin;
        public event ProcessingQuery EndingQuery;
        public event ProcessingQuery BeginningQuery;
        AsyncCallback callback;
        private IAsyncResult IAsyncStop;
        private bool _isExecuting;

        public string Nombre;
        public string Paht;
        public string CadenaConexion;
        public string Hora;
        public string Key;
        public string Horario;
        public string Minutos;
        public bool Lunes;
        public bool Martes;
        public bool Miércoles;
        public bool Jueves;
        public bool Viernes;
        public bool Sábado;
        public bool Domingo;
        public bool DBoDirectorio;
        public override string ToString()
        {
            return Nombre;
        }
        public void CreaRespaldoDB()
        {
            //hay que ejecutar el respaldo del la base de datos
            //obtengo el nombre del archivo
            if (isExecuting)
                return;
            MensajeError("inicia Respaldo de: " + Nombre);
            Estatus = "Respaldando " +Nombre;
            callback = new AsyncCallback(HandleCallback);
            System.Data.SqlClient.SqlCommand Command = null;
            System.Data.SqlClient.SqlConnection Conexion = null;
            string nombre = Nombre + System.DateTime.Now.Day.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Year.ToString() + " " + System.DateTime.Now.Hour.ToString() + " " + System.DateTime.Now.Minute.ToString() + " " + Horario;
            //obtengo la cadena de conexion
            string connexonstring = Desencriptar(CadenaConexion, Key);
            //genero la conexion a la base de datos
            if (Conexion == null)
            {
                Conexion = new System.Data.SqlClient.SqlConnection();
            }
            //modificado para permitir procesamiento asincrono
            try
            {
                if (Conexion.ConnectionString.Contains("Asynchronous Processing=true;"))
                    Conexion.ConnectionString = connexonstring;
                else
                    Conexion.ConnectionString = ConvierteCadena(connexonstring + ";") + "Asynchronous Processing=true;";
            }
            catch (Exception)
            {
                Conexion.ConnectionString = ConvierteCadena(connexonstring + ";");
            }

            //genero el query para generar el respaldo
            string s = "DECLARE @archivo VARCHAR(250)\n";
            s = s + "SET @archivo =\'" + Paht + "\\" + nombre + ".bak\'\n";
            s = s + "BACKUP DATABASE " + Conexion.Database + " TO DISK = @archivo";
            EndingQuery += new ProcessingQuery(FinQuery);
            Async_ObtenTablaQuery(s, Command, Conexion);
        }
        public void OnHora(int hora, int minuto, string horario, DayOfWeek dia)
        {
            if (hora != int.Parse(Hora))
                return;
            if (minuto != int.Parse(Minutos))
                return;
            if (horario != Horario)
                return;
            //selecciono el dia en que memencuentro
            switch(dia)
            {
                case DayOfWeek.Monday: //lunes
                    if(Lunes==false) //hoy no toca
                        return;
                    break;
                case DayOfWeek.Tuesday: //Martes
                    if(Martes==false) //hoy no toca
                        return;
                    break;
                case DayOfWeek.Wednesday: //Miércoles
                    if(Miércoles==false) //hoy no toca
                        return;
                    break;
                case DayOfWeek.Thursday: //Jueves
                    if(Jueves==false) //hoy no toca
                        return;
                    break;
                case DayOfWeek.Friday: //Viernes
                    if(Viernes==false) //hoy no toca
                        return;
                    break;
                case DayOfWeek.Saturday: //Sábado
                    if(Sábado==false) //hoy no toca
                        return;
                    break;
                case DayOfWeek.Sunday: //Domingo
                    if (Domingo == false) //hoy no toca
                        return;
                    break;
            }
            if (DBoDirectorio == true)
                CreaRespaldoDB();
            else
                RespaldaDirectorio();
        }
        private void FinQuery()
        {
            isExecuting = false;
            EndingQuery -= new ProcessingQuery(FinQuery);
            if (OnFinProceso != null)
                OnFinProceso(this);
            MensajeError("Se genero el respaldo de la base de datos " + Nombre);
            Estatus = "";
        }
        private string ConvierteCadena(string cadena)
        {
            System.Collections.ArrayList cadenas = new System.Collections.ArrayList();
            int i, n, k, j;
            string s = "";
            string s2 = "";
            string cadenafinal = "";
            n = cadena.Length;
            //separo la cadena de conexion en lineas
            for (i = 0; i < n; i++)
            {
                if (cadena[i] == ';')
                {
                    s = s + cadena[i];
                    cadenas.Add(s);
                    s = "";
                }
                else
                    s = s + cadena[i];
            }
            // elimino las lineas que no son soportadas
            n = cadenas.Count;
            for (i = 0; i < n; i++)
            {
                s = (string)cadenas[i];
                k = s.Length;
                for (j = 0; j < k; j++)
                {
                    if (s[j] == '=')
                    {

                        if (s2.ToLower() == "data source".ToLower())
                        {
                            cadenafinal = cadenafinal + s;
                            s2 = "";
                            break;
                        }
                        if (s2.ToLower() == "workstation id".ToLower())
                        {
                            cadenafinal = cadenafinal + s;
                            s2 = "";
                            break;
                        }
                        if (s2.ToLower() == "packet size".ToLower())
                        {
                            cadenafinal = cadenafinal + s;
                            s2 = "";
                            break;
                        }
                        if (s2.ToLower() == "integrated security".ToLower())
                        {
                            cadenafinal = cadenafinal + s;
                            s2 = "";
                            break;
                        }
                        if (s2.ToLower() == "persist security info".ToLower())
                        {
                            cadenafinal = cadenafinal + s;
                            s2 = "";
                            break;
                        }

                        if (s2.ToLower() == "Password".ToLower())
                        {
                            cadenafinal = cadenafinal + s;
                            s2 = "";
                            break;
                        }
                        if (s2.ToLower() == "User ID".ToLower())
                        {
                            cadenafinal = cadenafinal + s;
                            s2 = "";
                            break;
                        }
                        if (s2.ToLower() == "initial catalog".ToLower())
                        {
                            cadenafinal = cadenafinal + s;
                            s2 = "";
                            break;
                        }
                        s2 = "";
                        break;
                    }
                    else
                        s2 = s2 + s[j];
                }
            }
            return cadenafinal;
        }
        public string Desencriptar(string TextEncripted, string Key)
        {
            byte[] bytString, bytEncriptar, bytDesEncriptar;
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            RSACryptoServiceProvider sec = new RSACryptoServiceProvider();
            string strDesencriptar = "";
            if (TextEncripted != "")
            {
                try
                {
                    sec.FromXmlString(Key);
                    byte[] b = Convert.FromBase64String(TextEncripted);
                    bytDesEncriptar = sec.Decrypt(b, false);
                    strDesencriptar = ue.GetString(bytDesEncriptar);
                }
                catch (System.Exception ex)
                {
                    //                    MessageBox.Show(, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MensajeError("No se realizo la Desencripción " + ex.Message);
                }
            }
            return strDesencriptar;
        }
        #region Codigo para la ejecucion del respaldo
        public void Async_ObtenTablaQuery(string Query, System.Data.SqlClient.SqlCommand Command, System.Data.SqlClient.SqlConnection Conexion)
        {
            if (isExecuting)
                return;
            if (Command == null)
                Command = new System.Data.SqlClient.SqlCommand();
            if (Conexion == null)
            {
                MensajeError("No hay Conexion a la Base de Datos " + Nombre);
                return;
            }
            if (Query.Trim() == "")
            {
                MensajeError("Query Vacio...");
                return;
            }

            Command.CommandText = Query;
            Command.CommandType = CommandType.Text;
            Command.Connection = Conexion;
            Command.CommandTimeout = 5000;

            try
            {
                Command.Connection.Open();
                if (!isExecuting && BeginningQuery != null)
                    BeginningQuery();
                isExecuting = true;
                IAsyncStop = Command.BeginExecuteReader(callback, Command, CommandBehavior.CloseConnection);
                //                MensajeError = "OK";
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //MensajeError = ex.Message;
                Command.Connection.Close();
                if (isExecuting && EndingQuery != null)
                    EndingQuery();
                isExecuting = false;
                throw ex;
            }

        }
        private bool isExecuting
        {
            get
            {
                return _isExecuting;
            }
            set
            {
                if (value)
                {
                    Inicio = DateTime.Now;
                    _isExecuting = true;
                }
                else
                {
                    Fin = DateTime.Now;
                    _isExecuting = false;
                }
            }
        }

        private void HandleCallback(IAsyncResult result)
        {
            try
            {
                // Retrieve the original command object, passed
                // to this procedure in the AsyncState property
                // of the IAsyncResult parameter.
                System.Data.SqlClient.SqlCommand command = (System.Data.SqlClient.SqlCommand)result.AsyncState;
                System.Data.SqlClient.SqlDataReader reader = command.EndExecuteReader(result);
                // You may not interact with the form and its contents
                // from a different thread, and this callback procedure
                // is all but guaranteed to be running from a different thread
                // than the form. Therefore you cannot simply call code that 
                // fills the grid, like this:
                // FillGrid(reader);
                // Instead, you must call the procedure from the form's thread.
                // One simple way to accomplish this is to call the Invoke
                // method of the form, which calls the delegate you supply
                // from the form's thread. 
                DataSet Results = new DataSet();
                Results.Load(reader, LoadOption.OverwriteChanges, new string[] { "Tabla 1", "Tabla 2", "Tabla 3", "Tabla 4", "Tabla 5", "Tabla 6", "Tabla 7" });
                //FillGridDelegate del = new FillGridDelegate(FillGrid);
                //this.Invoke(del, reader);
                // Do not close the reader here, because it is being used in 
                // a separate thread. Instead, have the procedure you have
                // called close the reader once it is done with it.
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                // Because you are now running code in a separate thread, 
                // if you do not handle the exception here, none of your other
                // code catches the exception. Because there is none of 
                // your code on the call stack in this thread, there is nothing
                // higher up the stack to catch the exception if you do not 
                // handle it here. You can either log the exception or 
                // invoke a delegate (as in the non-error case in this 
                // example) to display the error on the form. In no case
                // can you simply display the error without executing a delegate
                // as in the try block here. 
                // You can create the delegate instance as you 
                // invoke it, like this:
                MensajeError("Error: " + ex.Message);
            }
            finally
            {
                if (isExecuting && EndingQuery != null)
                    EndingQuery();
                isExecuting = false;
            }
        }
        #endregion
        private void MensajeError(string msg)
        {
            //guarda un archivo con el registro de los errores generados
            string s = Principal.DirectorioExcutable + "Errores.txt";
            StreamWriter sw;
            sw = File.AppendText(s);
            sw.WriteLine(System.DateTime.Now.ToString() + "\t" + msg);
            sw.Close();
        }
        public void RespaldaDirectorio()
        {
            //Genera el respaldo del directorio
            Directorios = new List<string>();
            Directorios.Add(Desencriptar(CadenaConexion, Key));
            //TBuscar = new System.Windows.Forms.Timer();
            MensajeError("inicia Respaldo de: "+Nombre);
            Estatus = "inicia Respaldo de: " + Nombre;
            ThreadStart delegado = new ThreadStart(Respaldadir2);
            Thread tarea = new Thread(delegado);
            tarea.Start();
        }
        private void Respaldadir2()
        {
            //genero la lista de directorios a respaldar
            //aqui hay que poner el codigo para copiar los archivos y los archivos
            //veo si hay directorios en la lista
            while (Directorios.Count > 0)
            {
                if (Directorios.Count == 0)
                {
                    //ya no hay, por lo que ya termine
                    //TBuscar.Enabled = false;
                    if (OnFinProceso != null)
                        OnFinProceso(this);
                    Estatus = "";
                    return;
                }
                //me traigo el primer directorio de la lista
                string DirectorioOrigen = Directorios[0];
                Directorios.RemoveAt(0);
                //me traigo la lista de directorios
                string[] dirs;
                dirs = Directory.GetDirectories(DirectorioOrigen);
                //agrego los directorios a la lista
                foreach (string dir in dirs)
                {
                    Directorios.Add(dir);
                }
                //ahora filtro el directorio. Esto lo hago quitando el path origen
                string directorio = "";
                int i, n;
                string Dirx = Desencriptar(CadenaConexion, Key);
                n = Dirx.Length;
                directorio = DirectorioOrigen.Substring(n);
                string directoriodestino = Paht;
                //ahora verifico si existe el direcotio
                if (directorio != "")
                {
                    directoriodestino = directoriodestino + "\\" + directorio;
                    if (Directory.Exists(directoriodestino) == false)
                    {
                        //no existe, por lo que lo creo
                        Directory.CreateDirectory(directoriodestino);
                    }
                }
                //ahora me traigo la lista de archivos
                string[] archivos;
                archivos = Directory.GetFiles(DirectorioOrigen);
                foreach (string archivo in archivos)
                {
                    string Archviodestino = "";
                    //le quito el paht del archvio
                    int pos = 0;
                    n = archivo.Length;
                    for (i = n - 1; i >= 0; i--)
                    {
                        if (archivo[i] == '\\')
                        {
                            pos = i;
                            break;
                        }
                    }
                    Archviodestino = directoriodestino + "\\" + archivo.Substring(pos + 1);
                    //ahora hago la copia del archivo
                    try
                    {
                        Estatus = "copiando:" + archivo;
                        File.Copy(archivo, Archviodestino, true);
                    }
                    catch (System.Exception ex)
                    {
                        //encontre un error, por lo que mando el aviso
                        MensajeError(ex.Message);
                    }

                }
            }
            if (Directorios.Count == 0)
            {
                //ya no hay, por lo que ya termine
                //TBuscar.Enabled = false;
                if (OnFinProceso != null)
                    OnFinProceso(this);
                Estatus = "";
                return;
            }
        }
    }
}
