using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE PAGAMENTOS ===\n");

        // Criei pagamentos diferentes (cada um de uma classe derivada)
        Pagamento pagamento1 = new PagamentoCartao(120.00m, "Visa", "1234-5678-9012-3456", 3);
        Pagamento pagamento2 = new PagamentoBoleto(250.00m, "83670000001", DateTime.Now.AddDays(5));
        Pagamento pagamento3 = new PagamentoPix(75.00m, "email@exemplo.com", "qrcode123");

        // Instancio o processador de pagamentos
        ProcessadorPagamento processador = new ProcessadorPagamento();

        // Processamento polimórfico — todos tratados da mesma forma, mas com comportamentos diferentes
        processador.ProcessarPagamento(pagamento1);
        processador.ProcessarPagamento(pagamento2);
        processador.ProcessarPagamento(pagamento3);

        // Testando sobrecarga do método de auditoria
        processador.RegistrarAuditoria(pagamento1, "Auditoria especial de cartão");
    }
}
