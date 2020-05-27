using FirstXafProject.Orm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FirstXafProject.WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        string _ConnectionString;
        public Service1(string ConnectionString)
        {
            InitializeComponent();
            _ConnectionString = ConnectionString;
        }
        protected override void OnStart(string[] args)
        {
            XpoHelper.InitXpo(_ConnectionString);
        }

        protected override void OnStop()
        {
        }
    }
}
