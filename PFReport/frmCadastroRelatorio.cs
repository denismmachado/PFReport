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
using Oracle.DataAccess.Client;

namespace PFReport
{
    public partial class frmCadastroRelatorio : Form
    {
        //private ConexaoBD abreconexao;
        public frmCadastroRelatorio()
        {
            InitializeComponent();

            //abreconexao = new ConexaoBD();

            //abreconexao.AcessaBanco("plano", "plano", "desenv");
        }

        private void frmCadastroRelatorio_Load(object sender, EventArgs e)
        {
           string strsql = "SELECT *  FROM CAD_GRUPO_RELATORIO ORDER BY NOME";

            var cmdcbo = new OracleCommand(strsql, ConexaoBD.cnnconectar);

            var dacbo = new OracleDataAdapter(cmdcbo);
            var dtRetorno = new DataTable();
            dacbo.Fill(dtRetorno);

            cboGrupoRelatorio.DataSource = dtRetorno;
            cboGrupoRelatorio.DisplayMember = "NOME";
            cboGrupoRelatorio.ValueMember = "SEQ_GRUPO_RELATORIO";
            cboGrupoRelatorio.Refresh();

        }

        private void cboGrupoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seqgruporelatorio = cboGrupoRelatorio.SelectedValue;

        }
    }
}
