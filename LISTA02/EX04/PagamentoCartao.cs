using System;

// Professor, esse é o pagamento com cartão. Aqui temos a bandeira, número e número de parcelas.

public class PagamentoCartao : Pagamento
{
    public string Bandeira { get; set; }
    public string NumeroCartao { get; set; }
    public int Parcelas { get; set; }

    public PagamentoCartao(decimal valor, string bandeira, string numeroCartao, int parcelas)
        : base(valor)
    {
        Bandeira = bandeira;
        NumeroCartao = numeroCartao;
        Parcelas = parcelas;
    }

    public override void Processar()
    {
        Status = "Aprovado";
        Console.WriteLine("Pagamento com cartão processado com sucesso.");
    }

    public override void GerarRecibo()
    {
        Console.WriteLine($"[RECIBO CARTÃO] Valor: R${Valor:F2} - Parcelas: {Parcelas}x - Bandeira: {Bandeira}");
    }
}