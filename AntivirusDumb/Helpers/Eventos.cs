using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntivirusForm
{
    public class Eventos
    {

        public FileSystemWatcher watcher;
        public static Monitor _mon;
        public Eventos(Monitor mon)
        {
            _mon = mon;
        }

        public void Monitorizar()
        {
            watcher = new FileSystemWatcher();
            //watcher.Path = @"D:\cuarentena";
            try {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\cuarentena");
                watcher.Path = AppDomain.CurrentDomain.BaseDirectory + "\\cuarentena";
               
            }
            catch(Exception e)
            {
                MessageBox.Show("No se puede crear la carpeta de cuarentena " + e.ToString());
            }
            //watcher.Filter = "*.txt";            
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;            
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            
        }

        private static void OnDeleted(object source, RenamedEventArgs e)
        {
            MessageBox.Show(string.Format("Deleted: {0} {1}", e.FullPath, e.ChangeType));           
        }


        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType.ToString() == "Created")
            {
                string[] evento = new string[] { DateTime.Now.ToString(), e.FullPath, "Created" };
                _mon.actualizar(evento);
            }
            else if (e.ChangeType.ToString() == "Deleted")
            {
                string[] evento = new string[] { DateTime.Now.ToString(), e.FullPath, "Deleted" };
                _mon.actualizar(evento);
               
            }
            else if (e.ChangeType.ToString() == "Changed")
            {
                string[] evento = new string[] { DateTime.Now.ToString(), e.FullPath, "Changed" };
                _mon.actualizar(evento);
            }

            Thread.Sleep(10);
             
        }
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            string[] evento = new string[] { DateTime.Now.ToString(), e.FullPath, "Renamed" };
            _mon.actualizar(evento);
        }

 
    }
}
