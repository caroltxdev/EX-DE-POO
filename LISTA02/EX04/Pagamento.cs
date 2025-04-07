using System;

// Professor, essa é a classe abstrata base para todos os tipos de pagamento.
// Ela define o que todo pagamento precisa ter: valor, data, status e os métodos Processar e GerarRecibo.

public abstract class Pagamento
{
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public string Status { get; set; }

    public Pagamento(decimal valor)
    {
        Valor = valor;
        Data = DateTime.Now;
        Status = "Pendente";
    }

    // Método abstrato: obriga as classes filhas a implementarem seu próprio processamento.
    public abstract void Processar();

    // Método abstrato: obriga as classes filhas a gerar recibo personalizado.
    public abstract void GerarRecibo();
}