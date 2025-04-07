using System;
using System.Text;
using System.Collections.Generic;

// Professor, aqui eu demonstro o uso das classes com abstração.
// Todas são usadas como IArmazenamento, independente da implementação real.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE ARMAZENAMENTO ===\n");

        // Lista de diferentes tipos de armazenamento, todos vistos como IArmazenamento
        List<IArmazenamento> armazenamentos = new List<IArmazenamento>
        {
            new ArmazenamentoLocal(),
            new ArmazenamentoNuvem(),
            new ArmazenamentoMemoria()
        };

        // Para cada tipo, salvo um arquivo, carrego, excluo e listo os arquivos restantes
        foreach (var armazenamento in armazenamentos)
        {
            armazenamento.Salvar("documento.txt", Encoding.UTF8.GetBytes("Conteúdo de teste"));

            var conteudo = armazenamento.Carregar("documento.txt");
            Console.WriteLine($"Conteúdo lido: {Encoding.UTF8.GetString(conteudo)}");

            armazenamento.Excluir("documento.txt");

            Console.WriteLine($"Arquivos restantes: {string.Join(", ", armazenamento.Listar())}\n");
        }
    }
}

