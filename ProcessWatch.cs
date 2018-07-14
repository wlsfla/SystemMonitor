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
    public partial class ProcessWatch : Form
    {
        public ProcessWatch()
        {
            InitializeComponent();

            this.lvProcess.Columns.Add(new ColumnHeader().Name = "ProcessName");
            this.lvProcess.Columns.Add(new ColumnHeader().Name = "State");
            this.lvProcess.Columns.Add(new ColumnHeader().Name = "Path");
            this.lvProcess.Columns.Add(new ColumnHeader().Name = "Description");

            this.lvProcess.Columns[0].Width = 100;
            this.lvProcess.Columns[1].Width = 40;
            this.lvProcess.Columns[2].Width = 100;
            this.lvProcess.Columns[3].Width = 170;

            this.lvProcess.View = View.Details;
            this.lvProcess.GridLines = true;
            this.lvProcess.FullRowSelect = true;
            this.lvProcess.MultiSelect = true;
        }

        private void 탐색프로세스설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalProcessList tprocForm = new TotalProcessList();
            tprocForm.Show();
        }
    }
}
