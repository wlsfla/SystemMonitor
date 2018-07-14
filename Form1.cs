using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessWatch pw = new ProcessWatch();
            pw.Show();
            this.Hide();
        }
    }
}
