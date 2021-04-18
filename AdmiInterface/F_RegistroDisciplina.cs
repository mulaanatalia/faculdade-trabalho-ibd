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
    public partial class F_RegistroDisciplina : Form
    {
        private Insercao inserir = new Insercao();
        private Validacao validar = new Validacao();
        private Mensagem msg = new Mensagem();
        public F_RegistroDisciplina()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                inserir.disciplina(txbCodigo.Text, txbDisciplina.Text,
                    (int)upCargaHoraria.Value, cbEstatuto.Text, (int) upCredito.Value);
                msg.sucesso(inserir.Mensagem, "Disciplina");
            }
            catch (FormatException)
            {
                msg.erro(inserir.Mensagem, "Disciplina");
            }
        }
    }
}
