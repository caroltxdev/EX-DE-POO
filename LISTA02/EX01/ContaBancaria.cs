using System;
using System.Collections.Generic;

// Professor, essa é a classe da conta bancária. Todos os atributos principais são privados, respeitando o encapsulamento.

public class ContaBancaria
{
    private decimal _saldo;                // Saldo da conta (não pode ser alterado diretamente)
    private string _numeroConta;           // Número identificador da conta
    private string _titular;               // Nome do dono da conta
    private List<Transacao> _transacoes;   // Lista com o histórico de transações

    // Propriedades públicas só de leitura, pra expor os dados sem permitir alteração de fora
    public string NumeroConta => _numeroConta;
    public string Titular => _titular;
    public decimal Saldo => _saldo;

    // Construtor da conta bancária, exigindo número e titular no momento da criação
    public ContaBancaria(string numeroConta, string titular)
    {
        _numeroConta = numeroConta;
        _titular = titular;
        _saldo = 0;                        // Toda conta começa com saldo zero
        _transacoes = new List<Transacao>();
    }

    // Método pra depositar dinheiro na conta. Aqui eu valido se o valor é positivo.
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor do depósito deve ser positivo.");
            return;
        }

        _saldo += valor;
        _transacoes.Add(new Transacao(0, valor, "Depósito realizado")); // 0 = Depósito
    }

    // Método de saque, com validação de valor e saldo
    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor do saque deve ser positivo.");
            return;
        }

        if (valor > _saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
            return;
        }

        _saldo -= valor;
        _transacoes.Add(new Transacao(1, valor, "Saque realizado")); // 1 = Saque
    }

    // Esse método mostra todas as transações feitas e o saldo final
    public void VerExtrato()
    {
        Console.WriteLine($"Extrato da conta {NumeroConta} - Titular: {Titular}");
        foreach (var transacao in _transacoes)
        {
            Console.WriteLine(transacao);
        }
        Console.WriteLine($"Saldo atual: R${Saldo:F2}\n");
    }
}
