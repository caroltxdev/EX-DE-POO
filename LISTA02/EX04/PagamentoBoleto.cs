using System;

// Professor, esse é o pagamento por boleto, que possui código de barras e data de vencimento.

public class PagamentoBoleto : Pagamento
{
    public string CodigoBarras { get; set; }
    public DateTime DataVencimento { get; set; }

    public PagamentoBoleto(decimal valor, string codigoBarras, DateTime dataVencimento)
        : base(valor)
    {
        CodigoBarras = codigoBarras;
        DataVencimento = dataVencimento;
    }

    public override void Processar()
    {
        Status = "Aguardando Pagamento";
        Console.WriteLine("Boleto gerado. Aguardando pagamento.");
    }

    public override void GerarRecibo()
    {
        Console.WriteLine($"[RECIBO BOLETO] Valor: R${Valor:F2} - Vencimento: {DataVencimento.ToShortDateString()} - Código: {CodigoBarras}");
    }
}