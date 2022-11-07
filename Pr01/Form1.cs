using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            MessageBox.Show("Dnes je " + today.DayOfWeek + " " + today.Date.ToString("dd/MMMM/yyyy") + " Je to " + today.DayOfYear + ". den v roce");
            MessageBox.Show("Je " + today.Hour + " hodin " + today.Minute + " minut " + today.Second + " sekund");
        }
    }
}
