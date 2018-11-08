using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFSpelarPortalAdmin1.Logs;

namespace WFSpelarPortalAdmin1
{
    partial class FileService1 : ServiceBase
    {
        // declare filesystemwatch
        FileSystemWatcher watcher;

        public FileService1()
        {
            InitializeComponent();
        }

        public void OnStart()
        {
            // try create watcher onStart();
            try
            {
                string pathToFolder = @"C:\Users\Jonte\source\repos\WFSpelarPortalAdmin1\WFSpelarPortalAdmin1\Data-library";

                // init new filesystemwatch
                watcher = new FileSystemWatcher { Path = pathToFolder, IncludeSubdirectories = true, Filter = "*.*" };
                watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
                watcher.EnableRaisingEvents = true;
                watcher.Created += new FileSystemEventHandler(WatcherCreated);
                watcher.Renamed += new RenamedEventHandler(WatcherCreated);
                watcher.Changed += new FileSystemEventHandler(WatcherCreated);

                void WatcherCreated(object source, FileSystemEventArgs e)
                {
                    MessageBox.Show("New files have been found in the directory!");
                }
            }
            // failed? log this "service couldnt start"
            catch (Exception e)
            {
                FileLogger log = new FileLogger();
                log.Log($"The service was unable to start for because of exception {e}.");               
            }

        }



        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
