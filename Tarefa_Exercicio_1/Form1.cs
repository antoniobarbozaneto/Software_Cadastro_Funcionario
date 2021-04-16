using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_Exercicio_1
{
    public partial class Form1 : Form
    {
        Funcionario F;
        public Form1()
        {
            F = new Funcionario(); 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            F.Incluir(txb_Nome.Text, txb_Cpf.Text, txb_DataP.Text, txb_Salario.Text, txb_IdD.Text, txb_NomeD.Text);
        }

        private void btn_Exibir_Click(object sender, EventArgs e)
        {
            txb_Nome.Text = F.Nome;
            txb_Cpf.Text = F.Cpf;
            txb_DataP.Text = F.Sal.Data_Pag;
            txb_Salario.Text = Convert.ToString(F.Sal.Valor_Salario);
            txb_IdD.Text = Convert.ToString(F.Dep.Id);
            txb_NomeD.Text = F.Dep.Nome_Dep;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txb_Nome.Text = "";
            txb_Cpf.Text = "";
            txb_DataP.Text = "";
            txb_Salario.Text = "";
            txb_IdD.Text = "";
            txb_NomeD.Text = "";
        }
    }
}
