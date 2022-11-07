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

namespace Pr06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Birthday = Convert.ToDateTime(dateTimePicker1.Text);

            int rok = 17;
            int PocetDnu = Knih.PocetDni(Birthday, rok);

            if (PocetDnu > 0)
            {
                MessageBox.Show("Počet dnů od dovršení " + rok + " let uplynulo " + PocetDnu + " dnů");
            }
            else
            {
                MessageBox.Show("Smůla ! Chybí ti " + (PocetDnu * - 1) + " dnů");
            }
        }
    }
}
