namespace UPA_HELPER
{
    partial class ConcluirAtendimento
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
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_testecpf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_concluir_atd = new System.Windows.Forms.Button();
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
            this.btn_consultar.Font = new System.Drawing.Font("Franklin Gothic Book", 20F, System.Drawing.FontStyle.Bold);
            this.btn_consultar.Location = new System.Drawing.Point(349, 123);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(38, 41);
            this.btn_consultar.TabIndex = 22;
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_testecpf
            // 
            this.btn_testecpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_testecpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btn_testecpf.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.btn_testecpf.Location = new System.Drawing.Point(125, 129);
            this.btn_testecpf.Name = "btn_testecpf";
            this.btn_testecpf.Size = new System.Drawing.Size(217, 18);
            this.btn_testecpf.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(466, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(119, 213);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 26);
            this.lbl_nome.TabIndex = 25;
            // 
            // btn_concluir_atd
            // 
            this.btn_concluir_atd.BackColor = System.Drawing.Color.Transparent;
            this.btn_concluir_atd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_concluir_atd.FlatAppearance.BorderSize = 0;
            this.btn_concluir_atd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_concluir_atd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_concluir_atd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_concluir_atd.Font = new System.Drawing.Font("Franklin Gothic Book", 20F, System.Drawing.FontStyle.Bold);
            this.btn_concluir_atd.Location = new System.Drawing.Point(194, 257);
            this.btn_concluir_atd.Name = "btn_concluir_atd";
            this.btn_concluir_atd.Size = new System.Drawing.Size(118, 49);
            this.btn_concluir_atd.TabIndex = 26;
            this.btn_concluir_atd.UseVisualStyleBackColor = false;
            this.btn_concluir_atd.Click += new System.EventHandler(this.btn_concluir_atd_Click);
            // 
            // ConcluirAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UPA_HELPER.Properties.Resources.Concluir_Atendimento3;
            this.ClientSize = new System.Drawing.Size(505, 345);
            this.Controls.Add(this.btn_concluir_atd);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_testecpf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConcluirAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConcluirAtendimento";
            this.Load += new System.EventHandler(this.ConcluirAtendimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.TextBox btn_testecpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_concluir_atd;
    }
}