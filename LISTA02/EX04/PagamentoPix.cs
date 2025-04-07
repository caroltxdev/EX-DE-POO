using System;

// Professor, esse é o pagamento via Pix, que possui uma chave e QRCode.

public class PagamentoPix : Pagamento
{
    public string ChavePix { get; set; }
    public string QRCode { get; set; }

    public PagamentoPix(decimal valor, string chavePix, string qrCode)
        : base(valor)
    {
        ChavePix = chavePix;
        QRCode = qrCode;
    }

    public override void Processar()
    {
        Status = "Confirmado";
        Console.WriteLine("Pagamento via PIX processado com sucesso.");
    }

    public override void GerarRecibo()
    {
        Console.WriteLine($"[RECIBO PIX] Valor: R${Valor:F2} - Chave: {ChavePix}");
    }
}