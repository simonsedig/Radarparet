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
using System.Timers;
using WFSpelarPortalAdmin1.Logs;

namespace WFSpelarPortalAdmin1
{
    public partial class FileService1 : ServiceBase
    {
        // declare filesystemwatch
        FileSystemWatcher watcher;

        // log reference
        FileLogger log = new FileLogger();

        // path to folder
        string pathToFolder = @"C:\Users\Jonte\Desktop\WFSpelarPortalAdmin1\WFSpelarPortalAdmin1\Data-library";

        public FileService1()
        {
            InitializeComponent();
        }

        public void OnStart()
        {
            // try create watcher onStart();
            try
            {
                // init new filesystemwatch
                watcher = new FileSystemWatcher { Path = pathToFolder, IncludeSubdirectories = true, Filter = "*.*" };
                watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
                watcher.EnableRaisingEvents = true;
                watcher.Created += new FileSystemEventHandler(WatcherCreated);
                watcher.Renamed += new RenamedEventHandler(WatcherCreated);
                watcher.Changed += new FileSystemEventHandler(WatcherCreated);

                // log started service
                log.Log("Service has started successfully!");
            }
            // failed? log this "service couldnt start"
            catch (Exception e)
            {                
                log.Log($"The service was unable to start for because of exception {e}.");
            }
        }

        public void WatcherCreated(object source, FileSystemEventArgs e)
        {
            try
            {
                System.Windows.Forms.MessageBox.Show("New files have been found in the directory!");
                log.Log($"FileWatcher has detected a change in the directory!{pathToFolder}");
            }
            catch
            {
                log.Log("Service could not be used.. unknown error!");
            }
        }
        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
