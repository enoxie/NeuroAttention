using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpUpdate;

namespace NeuroAttention
{
    public partial class Form1 : Form, ISharpUpdatable
    {
        private MayaUpdater updater;

        public Form1()
        {
            InitializeComponent();
            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new MayaUpdater(this);
        }

        public string ApplicationName 
        {
            get { return "NeuroAttention"; }
        }

        public string ApplicationID
        {
            get { return "NeuroAttention"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon 
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri ("http://www.enesbilgi.com/test/update.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }
    }
}
