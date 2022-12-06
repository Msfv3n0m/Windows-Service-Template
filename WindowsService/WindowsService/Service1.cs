using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService
{

    public partial class Service1 : ServiceBase
    {
        Timer Timer = new Timer();
        int Interval = 10000; // 10000 ms = 10 second  

        public Service1()
        {
            InitializeComponent();
            this.ServiceName = "SERVICENAME";
        }

        protected override void OnStart(string[] args)
        {

        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            //stuff
        }

        protected override void OnStop()
        {

        }
    }
}
