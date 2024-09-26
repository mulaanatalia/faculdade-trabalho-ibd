﻿using System;
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
    public partial class F_RegistroDocente : Form
    {
        public F_RegistroDocente()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void FotoDocente_Click(object sender, EventArgs e)
        {
            //Metodo para carregar ficheiros que fazem parte dos dados do usuario. Foto. Posteorimente pode ser usado para Carregar BI
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files( *.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                FotoUsuario.Image = new Bitmap(open.FileName);
               
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
