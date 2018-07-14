using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace SystemMonitor
{
    public partial class TotalProcessList : Form
    {
        public TotalProcessList()
        {
            InitializeComponent();

            this.lvTotalProcessList.Columns.Add(new ColumnHeader().Name = "ProcessName");
            this.lvTotalProcessList.Columns.Add(new ColumnHeader().Name = "State");
            this.lvTotalProcessList.Columns.Add(new ColumnHeader().Name = "Path");
            this.lvTotalProcessList.Columns.Add(new ColumnHeader().Name = "Description");

            this.lvTotalProcessList.Columns[0].Width = 100;
            this.lvTotalProcessList.Columns[1].Width = 40;
            this.lvTotalProcessList.Columns[2].Width = 100;
            this.lvTotalProcessList.Columns[3].Width = 170;

            this.lvTotalProcessList.View = View.Details;
            this.lvTotalProcessList.GridLines = true;
            this.lvTotalProcessList.MultiSelect = true;

            this.SetProcessList();
        }

        private void SetProcessList()
        {
            Process[] procList = Process.GetProcesses();

            for (int i = 0; i < procList.Length; i++)
            {
                this.lvTotalProcessList.Items.Add(SetlvItem(procList[i]));
            }
        }

        private ListViewItem SetlvItem(Process proc)
        {
            string[] s = new string[4];
            s[0] = proc.MainModule.ModuleName;
            s[1] = this.GetRespontStr(proc.Responding);
            s[2] = proc.MainModule.FileName;
            s[3] = proc.MainModule.FileVersionInfo.FileDescription;

            return new ListViewItem(s);
        }

        private string GetRespontStr(bool value)
        {
            if (value)
                return "실행";
            else
                return "중지";
        }

        

    }
}
