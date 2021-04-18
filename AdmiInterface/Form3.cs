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
    public partial class Form3 : Form
    {
        private Validacao validar = new Validacao();
        public Form3()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Metodo para verificar se a espacos em branco. 
            string msgErro = "O Espaço não pode estar vazio";
            try
            {
                validar.campo(NomeEstudante.Text);
                validar.campo(ApelidoEstudante.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show(msgErro, "Campo Vazio");
            }
           



        }

        private void Fotousuario_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FotoDocente_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string strCon = @"server=localhost;user id=root;pwd=laice;database=controlo_assiduidade; ";
            MySqlConnection cn = new MySqlConnection(strCon);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into controlo_assiduidade values('"+NomeEstudante.Text+"', "+ApelidoEstudante.Text+", default)";
            comm.ExecuteNonQuery();
            comm.Connection.Close();
            MessageBox.Show("Inserido com sucesso");
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            //Metodo para carregar ficheiros que fazem parte dos dados do usuario. Foto. Posteorimente pode ser usado para Carregar BI
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files( *.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                FotoUsuario.Image = new Bitmap(open.FileName);
               
            }
        }
    }
}
