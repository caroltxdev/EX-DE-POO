using System;

// Professor, essa classe centraliza o processamento de qualquer tipo de pagamento.
// Aqui eu aplico polimorfismo em tempo de execução e também sobrecarga de métodos (tempo de compilação).

public class ProcessadorPagamento
{
    // Polimorfismo em tempo de execução: método que aceita qualquer tipo de pagamento derivado da classe base
    public void ProcessarPagamento(Pagamento pagamento)
    {
        pagamento.Processar();
        pagamento.GerarRecibo();
        RegistrarAuditoria(pagamento);
    }

    // Sobrecarga: posso registrar só o pagamento
    public void RegistrarAuditoria(Pagamento pagamento)
    {
        Console.WriteLine($"[AUDITORIA] Pagamento de R${pagamento.Valor:F2} - Status: {pagamento.Status} - Data: {pagamento.Data}\n");
    }

    // Sobrecarga: posso registrar com mensagem extra
    public void RegistrarAuditoria(Pagamento pagamento, string mensagem)
    {
        Console.WriteLine($"[AUDITORIA] {mensagem} - Valor: R${pagamento.Valor:F2} - Status: {pagamento.Status}\n");
    }
}