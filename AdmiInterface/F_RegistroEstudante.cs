using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdmiInterface
{
    public partial class txbTipoBi : Form
    {
        private Validacao validar = new Validacao();
        private Insercao inserir = new Insercao();
        public txbTipoBi()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            string pNome=txbPNome.Text, uNome = txbPNome.Text, dtNasc = dtNascimento.Value.ToString(),
                sexo = cbGenero.Text, nacionalidade = txbNacionalidade.Text, naturalidade = txbNaturalidade.Text,
                eCivil = cbECivil.Text, identidade = cbTipoId.Text, nrIdentidade = txbNRID.Text, email = txbemail.Text,
                dataIngresso = dtIngresso.Value.ToString(), codCurso = cbCurso.Text;
            int []tel = { (int) upTel1.Value, (int) upTel2.Value };
            string[] morada = { txbCidade.Text, txbLocalidade.Text, txbQuarteirao.Text, txbNumCasa.Text};

            try
            {
                inserir.estudante(01,pNome,uNome, sexo.First(), dtNasc, eCivil,
                    nacionalidade, naturalidade, dataIngresso, identidade, nrIdentidade,
                    email, tel, morada, codCurso);
            }
            catch (FormatException)
            {

            }
        }
        private void mensagemDeErro(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
