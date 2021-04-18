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
    public partial class F_MenuRegistros : Form
    {
        public F_MenuRegistros()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // Este form Facilita as abertora de quase todas as te
        private void Button1_Click_1(object sender, EventArgs e)
        {
            F_RegistroEstudante openform = new F_RegistroEstudante();
            openform.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            F_RegistroDocente opebform = new F_RegistroDocente();
            opebform.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            F_RegistroCurso openform = new F_RegistroCurso();
            openform.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            F_RegistroDisciplina openform = new F_RegistroDisciplina();
            openform.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            F_RegistroTurmas openform = new F_RegistroTurmas();
            openform.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            F_LinkarDisciplinaCurso openform = new F_LinkarDisciplinaCurso();
            openform.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            F_LinkarDisciplinaDocente openform = new F_LinkarDisciplinaDocente();
            openform.ShowDialog();
        }
    }
}
