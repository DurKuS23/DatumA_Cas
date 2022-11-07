using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jmeno = string.Empty;
            string prijmeni = string.Empty;
            string datum = string.Empty;
            string[] slova;

            DateTime Date;
            DateTime Oldest = DateTime.Today;

            for (int k = 0; k < textBox1.Lines.Count(); k++)
            {
                string Info = textBox1.Lines[k];
                slova = Info.Split(';');

                Date = Convert.ToDateTime(slova[2]);

                if (Date < Oldest)
                {
                    jmeno = slova[0];
                    prijmeni = slova[1];
                    Oldest = Date;
                }
            }
            MessageBox.Show("Nejstarší " + jmeno + " " + prijmeni + " je narozen " + Oldest.ToString("d"));

        }
    }
}
