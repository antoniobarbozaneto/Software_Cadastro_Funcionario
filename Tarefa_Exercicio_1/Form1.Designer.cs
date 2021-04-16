
namespace Tarefa_Exercicio_1
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
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Cpf = new System.Windows.Forms.TextBox();
            this.txb_DataP = new System.Windows.Forms.TextBox();
            this.txb_Salario = new System.Windows.Forms.TextBox();
            this.txb_IdD = new System.Windows.Forms.TextBox();
            this.txb_NomeD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Exibir = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(141, 22);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(100, 20);
            this.txb_Nome.TabIndex = 0;
            // 
            // txb_Cpf
            // 
            this.txb_Cpf.Location = new System.Drawing.Point(141, 48);
            this.txb_Cpf.Name = "txb_Cpf";
            this.txb_Cpf.Size = new System.Drawing.Size(100, 20);
            this.txb_Cpf.TabIndex = 1;
            // 
            // txb_DataP
            // 
            this.txb_DataP.Location = new System.Drawing.Point(141, 74);
            this.txb_DataP.Name = "txb_DataP";
            this.txb_DataP.Size = new System.Drawing.Size(100, 20);
            this.txb_DataP.TabIndex = 2;
            // 
            // txb_Salario
            // 
            this.txb_Salario.Location = new System.Drawing.Point(141, 100);
            this.txb_Salario.Name = "txb_Salario";
            this.txb_Salario.Size = new System.Drawing.Size(100, 20);
            this.txb_Salario.TabIndex = 3;
            // 
            // txb_IdD
            // 
            this.txb_IdD.Location = new System.Drawing.Point(141, 126);
            this.txb_IdD.Name = "txb_IdD";
            this.txb_IdD.Size = new System.Drawing.Size(100, 20);
            this.txb_IdD.TabIndex = 4;
            // 
            // txb_NomeD
            // 
            this.txb_NomeD.Location = new System.Drawing.Point(141, 152);
            this.txb_NomeD.Name = "txb_NomeD";
            this.txb_NomeD.Size = new System.Drawing.Size(100, 20);
            this.txb_NomeD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cpf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Pagamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id Departamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome Departamento:";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(68, 178);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 12;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Exibir
            // 
            this.btn_Exibir.Location = new System.Drawing.Point(149, 178);
            this.btn_Exibir.Name = "btn_Exibir";
            this.btn_Exibir.Size = new System.Drawing.Size(75, 23);
            this.btn_Exibir.TabIndex = 13;
            this.btn_Exibir.Text = "Exibir";
            this.btn_Exibir.UseVisualStyleBackColor = true;
            this.btn_Exibir.Click += new System.EventHandler(this.btn_Exibir_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(230, 178);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 14;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_Cpf);
            this.groupBox1.Controls.Add(this.btn_Limpar);
            this.groupBox1.Controls.Add(this.txb_Nome);
            this.groupBox1.Controls.Add(this.btn_Exibir);
            this.groupBox1.Controls.Add(this.txb_DataP);
            this.groupBox1.Controls.Add(this.btn_Gravar);
            this.groupBox1.Controls.Add(this.txb_Salario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txb_IdD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_NomeD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 235);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Funcionário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 267);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Cpf;
        private System.Windows.Forms.TextBox txb_DataP;
        private System.Windows.Forms.TextBox txb_Salario;
        private System.Windows.Forms.TextBox txb_IdD;
        private System.Windows.Forms.TextBox txb_NomeD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Exibir;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

