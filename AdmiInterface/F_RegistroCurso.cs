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
    public partial class F_RegistroCurso : Form
    {
        private Validacao validar = new Validacao();
        private Insercao inserir = new Insercao();
        private Mensagem msg = new Mensagem();
        public F_RegistroCurso()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_criar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar campos
                inserir.curso(txbCodigo.Text, txbCurso.Text, (int) upDuracao.Value, rcDescricao.Text);
                msg.sucesso(inserir.Mensagem, "Curso");
            }
            catch (FormatException)
            {
                msg.erro(inserir.Mensagem, "Curso");
            }
        }
    }
}
