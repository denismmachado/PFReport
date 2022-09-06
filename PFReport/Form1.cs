using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFReport.Conexao;


namespace PFReport
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Você precisa informar um usuário", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ConexaoBD.usuario = txtUsuario.Text;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Você precisa informar uma senha", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ConexaoBD.senha = txtSenha.Text;
            }

            if (txtBanco.Text == "")
            {
                MessageBox.Show("Você precisa informar um banco", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ConexaoBD.banco = txtBanco.Text;
            }

            ConexaoBD.AcessaBanco(ConexaoBD.usuario, ConexaoBD.senha, ConexaoBD.banco);

            
            new frmTelaInicial().Show();
            Hide();

        }
    }
}
