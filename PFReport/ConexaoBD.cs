using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace PFReport.Conexao
{

    public class ConexaoBD
    {
        public static OracleConnection cnnconectar ;

        public static string usuario;
        public static string senha;
        public static string banco;

        public static void AcessaBanco(string usuario, string senha, string banco)
        {
            string Conexao = "User Id= " + usuario + ";Password=" + senha + ";Data Source=" + banco + ";ENLIST=false";

            cnnconectar = new OracleConnection(Conexao);

            if (cnnconectar.State == ConnectionState.Closed)
            {
                cnnconectar.Open();
            }

        }
    }
}
