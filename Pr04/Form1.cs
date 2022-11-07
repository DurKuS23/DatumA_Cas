using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Date = Convert.ToDateTime(dateTimePicker1.Text);
            string den = Date.DayOfWeek.ToString();


            // MessageBox.Show("Dnes je den " + den); // den vypisuje dny

            string zprava = string.Empty;
            switch (den)
            {
                case "Monday":
                    {
                        zprava = den + " je první den v týdnu";
                        break;
                    }
                case "Sunday":
                    {
                        zprava = den + " je poslední den v týdnu";
                        break;
                    }
                default:
                    {
                        zprava = den + " Nejedná se o první ani poslední den v týdnu ";
                        break;
                    }
            }
            MessageBox.Show(zprava);
        }
    }
}
