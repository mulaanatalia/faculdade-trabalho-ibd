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
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }
        //Senhas Dos Usuarios. Posteriomente as senhas seram armazenadas na base de dados
        private string  Adimusuario = "Adim" ,Adimsenha = "adim224";
        private string EtdUsuario = "Estudate", EtdSenha = "UJC2021";
        private string DctUsuario = "Docente", DctSenha = "DOC2021";

        private void Button1_Click(object sender, EventArgs e)
        {
            // Para iniciar as telas 
            F_MenuRegistros adim = new F_MenuRegistros();
            F_PresencaEstudante Estudate = new F_PresencaEstudante();
            F_PresencaDocente Docente = new F_PresencaDocente();
           
           // Metood para redecioanar os usuarios segundo os seus dados
           //O if sera alterado para verificar se as senha sao semelhates ou nao. 
            if(nomeUsuario.Text == "" && senhaUsuario.Text == "")
            {
                adim.ShowDialog();
               
            }

            else
            {
                
            }
            if (nomeUsuario.Text == EtdUsuario && senhaUsuario.Text == EtdSenha)
            {
                Estudate.ShowDialog();
            }
            else
            {
                
            }
            if (nomeUsuario.Text == DctUsuario && senhaUsuario.Text == DctSenha)
            {
                Docente.ShowDialog();
            }
            else
            {
               
            }
            if((nomeUsuario.Text == Adimusuario && senhaUsuario.Text == Adimsenha) ^
                ( nomeUsuario.Text == EtdUsuario && senhaUsuario.Text == EtdSenha)^
                (nomeUsuario.Text == DctUsuario && senhaUsuario.Text == DctSenha))
            {

            }
            else
            {
                //Metodo que da um altert quandos os dados dos usuarios nao contam da BS. 
                 String message = " Nome do Usuario ou Senha Ivalido. Pro favor tente novamente";
                 string titulo = " Erro No Açesso";
                 MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                 DialogResult result = MessageBox.Show(message, titulo, buttons);
                 if (result == DialogResult.Yes)
                 {

                 }
                 else
                 {
                    // fechara o programa se o usuario esqueceu a senha
                     this.Close();

                 }
            }

        }
    }
}
