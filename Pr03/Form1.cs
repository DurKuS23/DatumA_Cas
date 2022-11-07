using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "90/90/0009";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "000000\\/9000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // Datum narození 
            {
                DateTime birthday = Convert.ToDateTime(maskedTextBox1.Text);
                int age = Knih.CalculateAge(birthday, out int pocetdni);
                label2.Text = "Je ti " + age + " let nebo " + pocetdni + " dnů";

            }
            else if (radioButton2.Checked) // Rodné číslo
            {
                string datum = maskedTextBox1.Text;
                Knih.jeDatum(datum, out DateTime birthday, out string zprava);
                label1.Text = "" + zprava;
                int age = Knih.CalculateAge(birthday, out int pocetdni);
                label2.Text = "Je ti " + age + " let nebo " + pocetdni + " dnů";
            }
        }

      
    }
}
