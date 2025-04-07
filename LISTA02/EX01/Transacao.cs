using System;
using System.Collections.Generic;

// Professor, eu preferi usar int ao invés de enum pra treinar o uso de números como identificadores de tipo.
// Aqui, 0 = Depósito, 1 = Saque, 2 = Transferência.

public class Transacao
{
    public DateTime DataHora { get; }      // Momento exato em que a transação foi feita
    public int Tipo { get; }               // Tipo da transação, representado por um número
    public decimal Valor { get; }          // Valor movimentado
    public string Descricao { get; }       // Texto explicando a operação

    // Construtor da transação. Ele já guarda tudo no momento em que a operação é realizada.
    public Transacao(int tipo, decimal valor, string descricao)
    {
        DataHora = DateTime.Now;
        Tipo = tipo;
        Valor = valor;
        Descricao = descricao;
    }

    // Esse método serve pra transformar o número do tipo em texto, só pra deixar o extrato mais legível.
    private string TipoParaTexto()
    {
        return Tipo switch
        {
            0 => "Depósito",
            1 => "Saque",
            2 => "Transferência",
            _ => "Desconhecido"
        };
    }

    // Aqui eu sobrescrevo o ToString pra mostrar a transação de forma bonita no extrato.
    public override string ToString()
    {
        return $"{DataHora:G} - {TipoParaTexto()} - R${Valor:F2} - {Descricao}";
    }
}