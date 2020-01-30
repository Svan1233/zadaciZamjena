using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace svanTipuricZadaciZamjena2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }

        private void BtnStartInfo_Click(object sender, EventArgs e)
        {

        }

        private void BtnWord_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }
    }
    

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }
    }
