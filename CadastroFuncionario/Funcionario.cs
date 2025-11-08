using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{
    internal class Funcionario
    {
        public int id, cargaH;
        public double salario, vl_INSS;
        public string nomeF, funcao, departamento, data_Nacimento, data_Adimissao, plano_Saude;
        public string tabela = "funcionario";
        Conexao objConexao = new Conexao();

        public void cadastrarFuncionario()
        {
            // Comando :
            string cadastrar = $@"INSERT INTO {tabela} values 
                                (null,'{nomeF}','{funcao}','{departamento}','{data_Nacimento}','{cargaH}',
                                 '{data_Adimissao}','{salario}','{vl_INSS}','{plano_Saude}');";
            // Executar:
            objConexao.ExecutarComando(cadastrar);
        }

        public DataTable ListarFuncionario()
        {
            // Comando :
            string listar = $"SELECT * FROM {tabela} ORDER BY dataNsc;";
            // Executar/Retorno :
            return objConexao.ExecutarConsulta(listar);
        }
    }
}
