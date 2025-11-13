using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFuncionario
{
    public partial class frm_funcionario : Form
    {

        Funcionario objFuncionario = new Funcionario();

        public frm_funcionario()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            objFuncionario.nomeF = txt_nome.Text;
            objFuncionario.funcao = txt_funcao.Text;
            objFuncionario.departamento = txt_departamento.Text;
            objFuncionario.data_Nacimento = txt_dtNascimento.Text;
            objFuncionario.cargaH = int.Parse(txt_cargaHoraria.Text);
            objFuncionario.data_Adimissao = txt_dtAdimissao.Text;
            objFuncionario.salario = double.Parse(txt_salario.Text);
            objFuncionario.vl_INSS = double.Parse(txt_valorInss.Text);
            objFuncionario.plano_Saude = cbx_planoDeSaude.Text;

            objFuncionario.cadastrarFuncionario();
            MessageBox.Show("Funcionário cadastrado com sucesso");

            txt_nome.Clear();
            txt_funcao.Clear();
            txt_departamento.Clear();
            txt_dtNascimento.Clear();
            txt_dtAdimissao.Clear();
            cbx_planoDeSaude.SelectedIndex = 0;

            dtg_funcionarios.DataSource = objFuncionario.ListarFuncionario();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_funcao.Clear();
            txt_departamento.Clear();
            txt_dtNascimento.Clear();
            txt_dtAdimissao.Clear();
            txt_salario.Clear();
            txt_valorInss.Clear();
            txt_cargaHoraria.Clear();
            cbx_planoDeSaude.SelectedIndex = 0;
        }

        private void frm_funcionario_Load(object sender, EventArgs e)
        {
            dtg_funcionarios.DataSource = objFuncionario.ListarFuncionario();
        }
    }
}
