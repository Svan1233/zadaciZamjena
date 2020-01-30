using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svanTipuricZadaciZamjena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite Yes / No / Cancel", "Naslovna linija Dijaloga za poruke", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            DialogResult rez = MessageBox.Show("Odaberite Yes / No / Cancel", "Naslovna linija Dijaloga za poruke", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            switch (rez)
            {
                case DialogResult.Yes:
                    textBox1.Text = "Izabrali ste dugme YES";
                    break;
                case DialogResult.No:
                    textBox1.Text = "Izabrali ste dugme NO";
                    break;
                case DialogResult.Cancel:
                    textBox1.Text = "Izabrali ste dugme Cancel";
                    break;
            }

        }
    }
}
