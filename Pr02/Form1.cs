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

namespace Pr02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthday = Convert.ToDateTime(dateTimePicker1.Text);

            int age = Knih.CalculateAge(birthday, out int pocetdni);

            MessageBox.Show("Je ti " + age + " let a " + pocetdni + " dnů");
        }
    }
}
