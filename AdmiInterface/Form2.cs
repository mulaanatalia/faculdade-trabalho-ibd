using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmiInterface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // Este form Facilita as abertora de quase todas as te
        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form3 openform = new Form3();
            openform.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form4 opebform = new Form4();
            opebform.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form5 openform = new Form5();
            openform.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form6 openform = new Form6();
            openform.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form7 openform = new Form7();
            openform.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form8 openform = new Form8();
            openform.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form9 openform = new Form9();
            openform.ShowDialog();
        }
    }
}
