using System;

// Professor, essa classe simula uma conexão com banco de dados.
// Ela implementa IDisposable corretamente, com Dispose padrão, bool, finalizador e flag.

public class GerenciadorConexaoBD : IDisposable
{
    private bool disposed = false; // Flag para evitar múltiplas chamadas de Dispose

    public GerenciadorConexaoBD()
    {
        Console.WriteLine("Conexão com banco de dados iniciada.");
    }

    // Método que simula execução de uma consulta
    public void ExecutarConsulta(string sql)
    {
        if (disposed)
            throw new ObjectDisposedException("GerenciadorConexaoBD");

        Console.WriteLine($"Executando SQL: {sql}");
    }

    // Implementação pública de Dispose
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this); // Evita chamada do finalizador depois do Dispose manual
    }

    // Dispose com parâmetro bool: padrão recomendado
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Liberar recursos gerenciados aqui
                Console.WriteLine("Liberando recursos gerenciados (ex: conexão).");
            }

            // Liberar recursos não gerenciados aqui (se houvesse)
            Console.WriteLine("Liberando recursos não gerenciados (ex: handles).");

            disposed = true;
        }
    }

    // Finalizador (chamado se Dispose não for chamado manualmente)
    ~GerenciadorConexaoBD()
    {
        Dispose(false);
    }
}
