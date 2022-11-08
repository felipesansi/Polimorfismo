namespace Aula11
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Txt_salario = new System.Windows.Forms.TextBox();
            this.Txt_tempo = new System.Windows.Forms.TextBox();
            this.Lbl_valor = new System.Windows.Forms.Label();
            this.btn_inss = new System.Windows.Forms.Button();
            this.btn_ferias = new System.Windows.Forms.Button();
            this.btn_comissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo de serviço(meses):";
            // 
            // Txt_nome
            // 
            this.Txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nome.Location = new System.Drawing.Point(133, 60);
            this.Txt_nome.Multiline = true;
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(286, 38);
            this.Txt_nome.TabIndex = 3;
            // 
            // Txt_salario
            // 
            this.Txt_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_salario.Location = new System.Drawing.Point(133, 140);
            this.Txt_salario.Multiline = true;
            this.Txt_salario.Name = "Txt_salario";
            this.Txt_salario.Size = new System.Drawing.Size(286, 38);
            this.Txt_salario.TabIndex = 4;
            // 
            // Txt_tempo
            // 
            this.Txt_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tempo.Location = new System.Drawing.Point(236, 223);
            this.Txt_tempo.Multiline = true;
            this.Txt_tempo.Name = "Txt_tempo";
            this.Txt_tempo.Size = new System.Drawing.Size(286, 38);
            this.Txt_tempo.TabIndex = 5;
            // 
            // Lbl_valor
            // 
            this.Lbl_valor.AutoSize = true;
            this.Lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_valor.Location = new System.Drawing.Point(289, 298);
            this.Lbl_valor.Name = "Lbl_valor";
            this.Lbl_valor.Size = new System.Drawing.Size(0, 20);
            this.Lbl_valor.TabIndex = 6;
            // 
            // btn_inss
            // 
            this.btn_inss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inss.Location = new System.Drawing.Point(293, 352);
            this.btn_inss.Name = "btn_inss";
            this.btn_inss.Size = new System.Drawing.Size(151, 49);
            this.btn_inss.TabIndex = 7;
            this.btn_inss.Text = "Calcular INSS";
            this.btn_inss.UseVisualStyleBackColor = true;
            this.btn_inss.Click += new System.EventHandler(this.btn_inss_Click_1);
            // 
            // btn_ferias
            // 
            this.btn_ferias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ferias.Location = new System.Drawing.Point(121, 352);
            this.btn_ferias.Name = "btn_ferias";
            this.btn_ferias.Size = new System.Drawing.Size(151, 49);
            this.btn_ferias.TabIndex = 8;
            this.btn_ferias.Text = "Calcular férias";
            this.btn_ferias.UseVisualStyleBackColor = true;
            this.btn_ferias.Click += new System.EventHandler(this.btn_ferias_Click_1);
            // 
            // btn_comissao
            // 
            this.btn_comissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comissao.Location = new System.Drawing.Point(474, 352);
            this.btn_comissao.Name = "btn_comissao";
            this.btn_comissao.Size = new System.Drawing.Size(168, 49);
            this.btn_comissao.TabIndex = 9;
            this.btn_comissao.Text = "Calcular comissão";
            this.btn_comissao.UseVisualStyleBackColor = true;
            this.btn_comissao.Click += new System.EventHandler(this.btn_comissao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btn_comissao);
            this.Controls.Add(this.btn_ferias);
            this.Controls.Add(this.btn_inss);
            this.Controls.Add(this.Lbl_valor);
            this.Controls.Add(this.Txt_tempo);
            this.Controls.Add(this.Txt_salario);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.TextBox Txt_salario;
        private System.Windows.Forms.TextBox Txt_tempo;
        private System.Windows.Forms.Label Lbl_valor;
        private System.Windows.Forms.Button btn_inss;
        private System.Windows.Forms.Button btn_ferias;
        private System.Windows.Forms.Button btn_comissao;
    }
}

