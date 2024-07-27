# Polimorfismo em C#

## Descrição

Este projeto demonstra o conceito de polimorfismo na programação orientada a objetos utilizando a linguagem C#. O polimorfismo permite que objetos de diferentes classes sejam tratados de forma uniforme através de uma interface comum ou uma classe base. Isso é exemplificado através de classes que representam diferentes tipos de funcionários.

## O que é Polimorfismo?

Polimorfismo é a capacidade de uma interface única ser utilizada por diferentes classes. Em C#, isso pode ser feito através de herança e interfaces. Existem dois tipos principais de polimorfismo:

1. **Polimorfismo de Sobrecarga (Compile-time Polymorphism)**: Ocorre quando métodos na mesma classe têm o mesmo nome, mas diferentes assinaturas.
2. **Polimorfismo de Substituição (Runtime Polymorphism)**: Ocorre quando um método definido em uma classe base é substituído por um método em uma classe derivada.

## Estrutura do Projeto

- **Classes Abstratas e Derivadas**: O projeto contém uma classe abstrata `Funcionario` e uma classe derivada `Vendedor` que exemplifica o polimorfismo de substituição.
- **Interface de Usuário**: Uma interface gráfica criada com Windows Forms permite a interação com os objetos e métodos polimórficos.

## Exemplos

### Classe Abstrata `Funcionario`

```csharp
using System;

namespace Aula11
{
    internal abstract class Funcionario
    {
        public abstract string Name { get; }
    }
}

### Classe derivada 

using System;

namespace Aula11
{
    internal class Vendedor : Funcionario
    {
        public override string Name
        {
            get;
        }
    }
}

### Classe para interface gráfica 
using System;
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
            Lbl_valor.Text = "Valor das férias = " + Funcionario.Calcular(int.Parse(Txt_tempo.Text)).ToString();
        }

        private void btn_inss_Click_1(object sender, EventArgs e)
        {
            Funcionario.Nome = Txt_nome.Text;
            Funcionario.Salario = double.Parse(Txt_salario.Text);
            Lbl_valor.Text = "Valor do INSS = " + Funcionario.Calcular().ToString();
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