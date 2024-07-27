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

