using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Funcionario Funcionario = new Funcionario(); 
      

        private void btn_ferias_Click_1(object sender, EventArgs e)
        {

            Funcionario.Nome = Txt_nome.Text;
            Funcionario.Salario = double.Parse(Txt_salario.Text);
            Lbl_valor.Text = "Valor das férias =" +
             Funcionario.Calcular(int.Parse(Txt_tempo.Text)).ToString();
            //
        }

        private void btn_inss_Click_1(object sender, EventArgs e)
        {


            Funcionario.Nome = Txt_nome.Text;
            Funcionario.Salario = double.Parse(Txt_salario.Text);
            Lbl_valor.Text = "Valor do INSS =" +
             Funcionario.Calcular().ToString();

        }

        private void btn_comissao_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.Nome = Txt_nome.Text;
            vendedor.Salario = double.Parse(Txt_salario.Text);
            Lbl_valor.Text = "Valor da comissao = " + vendedor.Calcular(6).ToString();
        }
    }
}
