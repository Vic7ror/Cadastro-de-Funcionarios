namespace CadastroFuncionario
{
    partial class frm_funcionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_dtNascimento = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_funcao = new System.Windows.Forms.TextBox();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_cargaHoraria = new System.Windows.Forms.TextBox();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.txt_valorInss = new System.Windows.Forms.TextBox();
            this.cbx_planoDeSaude = new System.Windows.Forms.ComboBox();
            this.txt_dtAdimissao = new System.Windows.Forms.MaskedTextBox();
            this.txt_dtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_planoDeSaude = new System.Windows.Forms.Label();
            this.lbl_valorInss = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_dtAdimissao = new System.Windows.Forms.Label();
            this.lbl_cargaHoraria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.dtg_funcionarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(3, 10);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(162, 18);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome do Funcionário:";
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Location = new System.Drawing.Point(3, 70);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(64, 18);
            this.lbl_funcao.TabIndex = 1;
            this.lbl_funcao.Text = "Função:";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(3, 141);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(112, 18);
            this.lbl_departamento.TabIndex = 2;
            this.lbl_departamento.Text = "Departamento:";
            // 
            // lbl_dtNascimento
            // 
            this.lbl_dtNascimento.AutoSize = true;
            this.lbl_dtNascimento.Location = new System.Drawing.Point(3, 213);
            this.lbl_dtNascimento.Name = "lbl_dtNascimento";
            this.lbl_dtNascimento.Size = new System.Drawing.Size(155, 18);
            this.lbl_dtNascimento.TabIndex = 3;
            this.lbl_dtNascimento.Text = "Data de Nascimento:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(9, 31);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(290, 26);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_funcao
            // 
            this.txt_funcao.Location = new System.Drawing.Point(6, 91);
            this.txt_funcao.Name = "txt_funcao";
            this.txt_funcao.Size = new System.Drawing.Size(293, 26);
            this.txt_funcao.TabIndex = 5;
            // 
            // txt_departamento
            // 
            this.txt_departamento.Location = new System.Drawing.Point(6, 162);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(293, 26);
            this.txt_departamento.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_cargaHoraria);
            this.panel1.Controls.Add(this.txt_salario);
            this.panel1.Controls.Add(this.txt_valorInss);
            this.panel1.Controls.Add(this.cbx_planoDeSaude);
            this.panel1.Controls.Add(this.txt_dtAdimissao);
            this.panel1.Controls.Add(this.txt_dtNascimento);
            this.panel1.Controls.Add(this.lbl_planoDeSaude);
            this.panel1.Controls.Add(this.lbl_valorInss);
            this.panel1.Controls.Add(this.lbl_salario);
            this.panel1.Controls.Add(this.lbl_dtAdimissao);
            this.panel1.Controls.Add(this.lbl_cargaHoraria);
            this.panel1.Controls.Add(this.lbl_nome);
            this.panel1.Controls.Add(this.lbl_funcao);
            this.panel1.Controls.Add(this.txt_departamento);
            this.panel1.Controls.Add(this.lbl_departamento);
            this.panel1.Controls.Add(this.txt_funcao);
            this.panel1.Controls.Add(this.lbl_dtNascimento);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 353);
            this.panel1.TabIndex = 8;
            // 
            // txt_cargaHoraria
            // 
            this.txt_cargaHoraria.Location = new System.Drawing.Point(342, 31);
            this.txt_cargaHoraria.Name = "txt_cargaHoraria";
            this.txt_cargaHoraria.Size = new System.Drawing.Size(289, 26);
            this.txt_cargaHoraria.TabIndex = 23;
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(342, 162);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(289, 26);
            this.txt_salario.TabIndex = 22;
            // 
            // txt_valorInss
            // 
            this.txt_valorInss.Location = new System.Drawing.Point(342, 234);
            this.txt_valorInss.Name = "txt_valorInss";
            this.txt_valorInss.Size = new System.Drawing.Size(289, 26);
            this.txt_valorInss.TabIndex = 21;
            // 
            // cbx_planoDeSaude
            // 
            this.cbx_planoDeSaude.FormattingEnabled = true;
            this.cbx_planoDeSaude.Items.AddRange(new object[] {
            "",
            "Sim",
            "Não"});
            this.cbx_planoDeSaude.Location = new System.Drawing.Point(173, 304);
            this.cbx_planoDeSaude.Name = "cbx_planoDeSaude";
            this.cbx_planoDeSaude.Size = new System.Drawing.Size(293, 26);
            this.cbx_planoDeSaude.TabIndex = 20;
            // 
            // txt_dtAdimissao
            // 
            this.txt_dtAdimissao.Location = new System.Drawing.Point(342, 91);
            this.txt_dtAdimissao.Mask = "00/00/0000";
            this.txt_dtAdimissao.Name = "txt_dtAdimissao";
            this.txt_dtAdimissao.Size = new System.Drawing.Size(289, 26);
            this.txt_dtAdimissao.TabIndex = 15;
            this.txt_dtAdimissao.ValidatingType = typeof(System.DateTime);
            // 
            // txt_dtNascimento
            // 
            this.txt_dtNascimento.Location = new System.Drawing.Point(6, 234);
            this.txt_dtNascimento.Mask = "00/00/0000";
            this.txt_dtNascimento.Name = "txt_dtNascimento";
            this.txt_dtNascimento.Size = new System.Drawing.Size(293, 26);
            this.txt_dtNascimento.TabIndex = 14;
            this.txt_dtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_planoDeSaude
            // 
            this.lbl_planoDeSaude.AutoSize = true;
            this.lbl_planoDeSaude.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_planoDeSaude.Location = new System.Drawing.Point(259, 283);
            this.lbl_planoDeSaude.Name = "lbl_planoDeSaude";
            this.lbl_planoDeSaude.Size = new System.Drawing.Size(124, 18);
            this.lbl_planoDeSaude.TabIndex = 12;
            this.lbl_planoDeSaude.Text = "Plano de Saúde:";
            // 
            // lbl_valorInss
            // 
            this.lbl_valorInss.AutoSize = true;
            this.lbl_valorInss.Location = new System.Drawing.Point(339, 213);
            this.lbl_valorInss.Name = "lbl_valorInss";
            this.lbl_valorInss.Size = new System.Drawing.Size(110, 18);
            this.lbl_valorInss.TabIndex = 11;
            this.lbl_valorInss.Text = "Valor do INSS:";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(339, 141);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(62, 18);
            this.lbl_salario.TabIndex = 10;
            this.lbl_salario.Text = "Salário:";
            // 
            // lbl_dtAdimissao
            // 
            this.lbl_dtAdimissao.AutoSize = true;
            this.lbl_dtAdimissao.Location = new System.Drawing.Point(339, 70);
            this.lbl_dtAdimissao.Name = "lbl_dtAdimissao";
            this.lbl_dtAdimissao.Size = new System.Drawing.Size(146, 18);
            this.lbl_dtAdimissao.TabIndex = 9;
            this.lbl_dtAdimissao.Text = "Data de Adimissão:";
            // 
            // lbl_cargaHoraria
            // 
            this.lbl_cargaHoraria.AutoSize = true;
            this.lbl_cargaHoraria.Location = new System.Drawing.Point(339, 10);
            this.lbl_cargaHoraria.Name = "lbl_cargaHoraria";
            this.lbl_cargaHoraria.Size = new System.Drawing.Size(112, 18);
            this.lbl_cargaHoraria.TabIndex = 8;
            this.lbl_cargaHoraria.Text = "Carga Horária:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cadastrar novo funcionário";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Khaki;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Location = new System.Drawing.Point(20, 412);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(272, 33);
            this.btn_cadastrar.TabIndex = 10;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(385, 412);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(272, 33);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // dtg_funcionarios
            // 
            this.dtg_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_funcionarios.Location = new System.Drawing.Point(678, 44);
            this.dtg_funcionarios.Name = "dtg_funcionarios";
            this.dtg_funcionarios.Size = new System.Drawing.Size(291, 401);
            this.dtg_funcionarios.TabIndex = 12;
            // 
            // frm_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 457);
            this.Controls.Add(this.dtg_funcionarios);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data de Nascimento:";
            this.Load += new System.EventHandler(this.frm_funcionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_dtNascimento;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_funcao;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txt_dtAdimissao;
        private System.Windows.Forms.MaskedTextBox txt_dtNascimento;
        private System.Windows.Forms.Label lbl_planoDeSaude;
        private System.Windows.Forms.Label lbl_valorInss;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_dtAdimissao;
        private System.Windows.Forms.Label lbl_cargaHoraria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_planoDeSaude;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.DataGridView dtg_funcionarios;
        private System.Windows.Forms.TextBox txt_cargaHoraria;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.TextBox txt_valorInss;
    }
}

