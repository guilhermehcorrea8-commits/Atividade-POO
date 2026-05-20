using System;
using aula_20_05.models;
using System.Collections.Generic;

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//------ Atividade 1 ------//

Pessoa pessoa = new Pessoa
{
    Nome = "Guilherme",
    Idade = 17
};

Aluno aluno = new Aluno
{
    Nome = "Carlos",
    Idade = 16,
    Nota = 9
};

Professor professor = new Professor
{
    Nome = "Marcos",
    Idade = 40,
    Salario = 5000
};

Diretor diretor = new Diretor
{
    Nome = "Ana",
    Idade = 50,
    Salario = 10000
};

pessoa.Apresentar();
aluno.MostrarNota();
professor.ApresentarSalario();
diretor.ApresentarSalario();


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//------ Atividade 2 ------//

List<Funcionarios> funcionarios = new List<Funcionarios>();

funcionarios.Add(new Gerentes
{
    Nome = "João",
    Salario = 8000
});

funcionarios.Add(new Desenvolvedores
{
    Nome = "\nVitor",
    Salario = 4000
});

funcionarios.Add(new Estagiarios
{
    Nome = "\nKleber",
    Salario = 1500
});

foreach (Funcionarios f in funcionarios)
{
    Console.WriteLine($"\nFuncionario: {f.Nome}");
    Console.WriteLine($"Salario: R${f.Salario}");
    Console.WriteLine($"Bônus: R${f.CalcularBonus()}");
    Console.WriteLine("-----------------------------");
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//------ Atividade 3 ------//

ContaCorrente cc = new ContaCorrente
{
    Numero = 1,
    Titular = "Carlos",
    TaxaSaque = 5
};

cc.Depositar(1000);
cc.Sacar(100);

Console.WriteLine($"Saldo Conta Corrente: {cc.Saldo}");

ContaPoupanca cp = new ContaPoupanca
{
    Numero = 2,
    Titular = "Maria",
    RendimentoMensal = 10
};

cp.Depositar(1000);
cp.AplicarRendimento();


Console.WriteLine($"Saldo Conta Poupança: {cp.Saldo}");

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//------ Atividade 4 ------//

Guerreiro guerreiro = new Guerreiro
{
    Nome = "\nThor",
    Vida = 120,
    Ataque = 50,
    Espada = "Espada de Ferro"
};

Mago mago = new Mago
{
    Nome = "\nMerlin",
    Vida = -10,
    Ataque = 70,
    Mana = 200
};

Arqueiro arqueiro = new Arqueiro
{
    Nome = "\nLegolas",
    Vida = 90,
    Ataque = 60,
    QuantidadeFlechas = 30
};

Console.WriteLine($"{guerreiro.Nome} - Vida: {guerreiro.Vida}");
Console.WriteLine($"{mago.Nome} - Vida: {mago.Vida}");
Console.WriteLine($"{arqueiro.Nome} - Vida: {arqueiro.Vida}");

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//------ Atividade 5 ------//

Pedido[] pedidos =
{
    new PedidoNormal { ValorTotal = 100 },
    new PedidoExpresso { ValorTotal = 200 },
    new PedidoInternacional { ValorTotal = 300 }
};

foreach (Pedido p in pedidos)
{
    Console.WriteLine($"\nValor do Pedido: R${p.ValorTotal}");
    Console.WriteLine($"Valor da Entrega: R${p.CalcularEntrega()}");
    Console.WriteLine("------------------------");
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

