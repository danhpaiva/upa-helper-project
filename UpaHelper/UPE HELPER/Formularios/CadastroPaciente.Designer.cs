namespace UPA_HELPER
{
    partial class CadastroPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPaciente));
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.dt_datanascimento = new System.Windows.Forms.DateTimePicker();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.rtb_descricao = new System.Windows.Forms.RichTextBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.cb_upa = new System.Windows.Forms.ComboBox();
            this.cb_medico = new System.Windows.Forms.ComboBox();
            this.btn_buscar_cpf = new System.Windows.Forms.Button();
            this.btn_atualizar_cpf = new System.Windows.Forms.Button();
            this.btn_limpar_dados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.txt_nome.Location = new System.Drawing.Point(71, 196);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(447, 18);
            this.txt_nome.TabIndex = 9;
            // 
            // txt_cpf
            // 
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpf.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.txt_cpf.Location = new System.Drawing.Point(69, 132);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(212, 18);
            this.txt_cpf.TabIndex = 0;
            // 
            // dt_datanascimento
            // 
            this.dt_datanascimento.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dt_datanascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dt_datanascimento.CustomFormat = "";
            this.dt_datanascimento.Font = new System.Drawing.Font("Franklin Gothic Book", 13F);
            this.dt_datanascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_datanascimento.Location = new System.Drawing.Point(557, 192);
            this.dt_datanascimento.Name = "dt_datanascimento";
            this.dt_datanascimento.Size = new System.Drawing.Size(165, 27);
            this.dt_datanascimento.TabIndex = 12;
            this.dt_datanascimento.Value = new System.DateTime(2020, 6, 3, 0, 0, 0, 0);
            // 
            // txt_rua
            // 
            this.txt_rua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rua.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.txt_rua.Location = new System.Drawing.Point(264, 260);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(455, 18);
            this.txt_rua.TabIndex = 13;
            // 
            // txt_bairro
            // 
            this.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bairro.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.txt_bairro.Location = new System.Drawing.Point(72, 324);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(302, 18);
            this.txt_bairro.TabIndex = 14;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(721, 13);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(47, 46);
            this.btn_sair.TabIndex = 17;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(476, 562);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(133, 40);
            this.btn_cadastrar.TabIndex = 16;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // rtb_descricao
            // 
            this.rtb_descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_descricao.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.rtb_descricao.Location = new System.Drawing.Point(72, 452);
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(647, 77);
            this.rtb_descricao.TabIndex = 18;
            this.rtb_descricao.Text = "";
            // 
            // cb_sexo
            // 
            this.cb_sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_sexo.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cb_sexo.Location = new System.Drawing.Point(67, 256);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(160, 28);
            this.cb_sexo.TabIndex = 19;
            this.cb_sexo.SelectedIndexChanged += new System.EventHandler(this.cb_sexo_SelectedIndexChanged);
            // 
            // cb_cidade
            // 
            this.cb_cidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_cidade.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Items.AddRange(new object[] {
            "Belo Horizonte",
            "Betim",
            "Contagem",
            "Ribeirão das Neves",
            "Sabará",
            "Sete Lagoas"});
            this.cb_cidade.Location = new System.Drawing.Point(412, 319);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(311, 28);
            this.cb_cidade.TabIndex = 20;
            // 
            // cb_upa
            // 
            this.cb_upa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_upa.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.cb_upa.FormattingEnabled = true;
            this.cb_upa.Items.AddRange(new object[] {
            "UPA Barreiro",
            "UPA Centro-Sul",
            "UPA Leste",
            "UPA Nordeste",
            "UPA Noroeste",
            "UPA Norte",
            "UPA Oeste",
            "UPA Pampulha",
            "UPA Venda Nova"});
            this.cb_upa.Location = new System.Drawing.Point(67, 384);
            this.cb_upa.Name = "cb_upa";
            this.cb_upa.Size = new System.Drawing.Size(311, 28);
            this.cb_upa.TabIndex = 21;
            // 
            // cb_medico
            // 
            this.cb_medico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_medico.Font = new System.Drawing.Font("Franklin Gothic Book", 11.5F);
            this.cb_medico.FormattingEnabled = true;
            this.cb_medico.Items.AddRange(new object[] {
            "Clínico Geral",
            "Pediatra",
            "Urologista",
            "Ortopedista",
            "Cardiologista"});
            this.cb_medico.Location = new System.Drawing.Point(412, 384);
            this.cb_medico.Name = "cb_medico";
            this.cb_medico.Size = new System.Drawing.Size(311, 28);
            this.cb_medico.TabIndex = 22;
            // 
            // btn_buscar_cpf
            // 
            this.btn_buscar_cpf.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_cpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_cpf.FlatAppearance.BorderSize = 0;
            this.btn_buscar_cpf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_cpf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_cpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_cpf.Location = new System.Drawing.Point(289, 124);
            this.btn_buscar_cpf.Name = "btn_buscar_cpf";
            this.btn_buscar_cpf.Size = new System.Drawing.Size(39, 34);
            this.btn_buscar_cpf.TabIndex = 23;
            this.btn_buscar_cpf.UseVisualStyleBackColor = false;
            this.btn_buscar_cpf.Click += new System.EventHandler(this.btn_buscar_cpf_Click);
            // 
            // btn_atualizar_cpf
            // 
            this.btn_atualizar_cpf.BackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar_cpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar_cpf.FlatAppearance.BorderSize = 0;
            this.btn_atualizar_cpf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar_cpf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_atualizar_cpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar_cpf.Location = new System.Drawing.Point(179, 562);
            this.btn_atualizar_cpf.Name = "btn_atualizar_cpf";
            this.btn_atualizar_cpf.Size = new System.Drawing.Size(117, 48);
            this.btn_atualizar_cpf.TabIndex = 24;
            this.btn_atualizar_cpf.UseVisualStyleBackColor = false;
            this.btn_atualizar_cpf.Click += new System.EventHandler(this.btn_atualizar_cpf_Click);
            // 
            // btn_limpar_dados
            // 
            this.btn_limpar_dados.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpar_dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar_dados.FlatAppearance.BorderSize = 0;
            this.btn_limpar_dados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_limpar_dados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_limpar_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar_dados.Location = new System.Drawing.Point(347, 124);
            this.btn_limpar_dados.Name = "btn_limpar_dados";
            this.btn_limpar_dados.Size = new System.Drawing.Size(90, 34);
            this.btn_limpar_dados.TabIndex = 25;
            this.btn_limpar_dados.UseVisualStyleBackColor = false;
            this.btn_limpar_dados.Click += new System.EventHandler(this.btn_limpar_dados_Click);
            // 
            // CadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(790, 650);
            this.Controls.Add(this.btn_limpar_dados);
            this.Controls.Add(this.btn_atualizar_cpf);
            this.Controls.Add(this.btn_buscar_cpf);
            this.Controls.Add(this.cb_medico);
            this.Controls.Add(this.cb_upa);
            this.Controls.Add(this.cb_cidade);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.rtb_descricao);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.dt_datanascimento);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroPaciente";
            this.Load += new System.EventHandler(this.CadastroPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.DateTimePicker dt_datanascimento;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.RichTextBox rtb_descricao;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.ComboBox cb_upa;
        private System.Windows.Forms.ComboBox cb_medico;
        private System.Windows.Forms.Button btn_buscar_cpf;
        private System.Windows.Forms.Button btn_atualizar_cpf;
        private System.Windows.Forms.Button btn_limpar_dados;
    }
}