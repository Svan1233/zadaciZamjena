using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace svanTipuricZadacaZamjena3
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        class Automobil
        {
            private string marka;
            public Automobil(string m)
            {
                marka = m;
            }
            public string DajMarku()
            {

               
                return marka;
                
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil(textBox1.Text);
            listaAutomobila.Add(a);
            richTextBox1.AppendText(listaAutomobila.IndexOf(a) + 1 + ". " + a.DajMarku() + "\n");
        }
    }
}
