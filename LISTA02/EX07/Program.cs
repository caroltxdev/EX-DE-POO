using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TESTE COM USING ===");

        // Professor, aqui eu uso using para garantir liberação automática,
        // mesmo que ocorra erro dentro do bloco.

        try
        {
            using (GerenciadorConexaoBD conexao = new GerenciadorConexaoBD())
            {
                conexao.ExecutarConsulta("SELECT * FROM usuarios");
                throw new Exception("Erro inesperado durante a consulta.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[EXCEÇÃO] {ex.Message}");
        }

        Console.WriteLine("\n=== TESTE COM CLASSE DERIVADA ===");

        // Aqui eu mostro o Dispose da hierarquia sendo chamado corretamente
        using (RecursoEspecializado recurso = new RecursoEspecializado())
        {
            Console.WriteLine("Usando recurso especializado...");
        }

        Console.WriteLine("\nPrograma finalizado.");
    }
}
