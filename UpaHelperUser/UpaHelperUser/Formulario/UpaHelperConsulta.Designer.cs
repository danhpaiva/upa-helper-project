namespace UpaHelperUser
{
    partial class UpaHelperConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpaHelperConsulta));
            this.btn_consultar = new System.Windows.Forms.Button();
            this.cb_nomeUPA = new System.Windows.Forms.ComboBox();
            this.lbl_qtdPaciente = new System.Windows.Forms.Label();
            this.lbl_enderecoUPA = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_telUtil = new System.Windows.Forms.Button();
            this.bnt_covid = new System.Windows.Forms.Button();
            this.btn_dev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.Transparent;
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.btn_consultar.ForeColor = System.Drawing.Color.White;
            this.btn_consultar.Location = new System.Drawing.Point(714, 305);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(25, 25);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // cb_nomeUPA
            // 
            this.cb_nomeUPA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_nomeUPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_nomeUPA.Font = new System.Drawing.Font("Franklin Gothic Book", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nomeUPA.FormattingEnabled = true;
            this.cb_nomeUPA.Items.AddRange(new object[] {
            "UPA Barreiro",
            "UPA Centro-Sul",
            "UPA Leste",
            "UPA Nordeste",
            "UPA Noroeste",
            "UPA Norte",
            "UPA Oeste",
            "UPA Pampulha",
            "UPA Venda Nova"});
            this.cb_nomeUPA.Location = new System.Drawing.Point(456, 303);
            this.cb_nomeUPA.Name = "cb_nomeUPA";
            this.cb_nomeUPA.Size = new System.Drawing.Size(246, 29);
            this.cb_nomeUPA.TabIndex = 3;
            // 
            // lbl_qtdPaciente
            // 
            this.lbl_qtdPaciente.AutoSize = true;
            this.lbl_qtdPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qtdPaciente.Font = new System.Drawing.Font("Franklin Gothic Book", 12.5F);
            this.lbl_qtdPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.lbl_qtdPaciente.Location = new System.Drawing.Point(531, 344);
            this.lbl_qtdPaciente.Name = "lbl_qtdPaciente";
            this.lbl_qtdPaciente.Size = new System.Drawing.Size(72, 21);
            this.lbl_qtdPaciente.TabIndex = 5;
            this.lbl_qtdPaciente.Text = "paciente";
            // 
            // lbl_enderecoUPA
            // 
            this.lbl_enderecoUPA.AutoSize = true;
            this.lbl_enderecoUPA.BackColor = System.Drawing.Color.Transparent;
            this.lbl_enderecoUPA.Font = new System.Drawing.Font("Franklin Gothic Book", 12.5F);
            this.lbl_enderecoUPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.lbl_enderecoUPA.Location = new System.Drawing.Point(449, 405);
            this.lbl_enderecoUPA.Name = "lbl_enderecoUPA";
            this.lbl_enderecoUPA.Size = new System.Drawing.Size(78, 21);
            this.lbl_enderecoUPA.TabIndex = 6;
            this.lbl_enderecoUPA.Text = "endereço";
            this.lbl_enderecoUPA.Click += new System.EventHandler(this.lbl_enderecoUPA_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.btn_sair.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sair.Location = new System.Drawing.Point(808, 7);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(30, 29);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_telUtil
            // 
            this.btn_telUtil.BackColor = System.Drawing.Color.Transparent;
            this.btn_telUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_telUtil.FlatAppearance.BorderSize = 0;
            this.btn_telUtil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_telUtil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_telUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_telUtil.ForeColor = System.Drawing.Color.Transparent;
            this.btn_telUtil.Location = new System.Drawing.Point(44, 187);
            this.btn_telUtil.Name = "btn_telUtil";
            this.btn_telUtil.Size = new System.Drawing.Size(85, 100);
            this.btn_telUtil.TabIndex = 7;
            this.btn_telUtil.UseVisualStyleBackColor = false;
            this.btn_telUtil.Click += new System.EventHandler(this.btn_telUtil_Click);
            // 
            // bnt_covid
            // 
            this.bnt_covid.BackColor = System.Drawing.Color.Transparent;
            this.bnt_covid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_covid.FlatAppearance.BorderSize = 0;
            this.bnt_covid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnt_covid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnt_covid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_covid.ForeColor = System.Drawing.Color.Transparent;
            this.bnt_covid.Location = new System.Drawing.Point(152, 187);
            this.bnt_covid.Name = "bnt_covid";
            this.bnt_covid.Size = new System.Drawing.Size(85, 91);
            this.bnt_covid.TabIndex = 8;
            this.bnt_covid.UseVisualStyleBackColor = false;
            this.bnt_covid.Click += new System.EventHandler(this.bnt_covid_Click);
            // 
            // btn_dev
            // 
            this.btn_dev.BackColor = System.Drawing.Color.Transparent;
            this.btn_dev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dev.FlatAppearance.BorderSize = 0;
            this.btn_dev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_dev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dev.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dev.Location = new System.Drawing.Point(260, 184);
            this.btn_dev.Name = "btn_dev";
            this.btn_dev.Size = new System.Drawing.Size(78, 94);
            this.btn_dev.TabIndex = 9;
            this.btn_dev.UseVisualStyleBackColor = false;
            this.btn_dev.Click += new System.EventHandler(this.btn_dev_Click);
            // 
            // UpaHelperConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.btn_dev);
            this.Controls.Add(this.bnt_covid);
            this.Controls.Add(this.btn_telUtil);
            this.Controls.Add(this.lbl_enderecoUPA);
            this.Controls.Add(this.lbl_qtdPaciente);
            this.Controls.Add(this.cb_nomeUPA);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpaHelperConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UpaHelperConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.ComboBox cb_nomeUPA;
        private System.Windows.Forms.Label lbl_qtdPaciente;
        private System.Windows.Forms.Label lbl_enderecoUPA;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_telUtil;
        private System.Windows.Forms.Button bnt_covid;
        private System.Windows.Forms.Button btn_dev;
    }
}

