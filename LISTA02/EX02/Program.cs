using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE GESTÃO DE PRODUTOS ===\n");

        try
        {
            // Produto completo com todos os dados
            Produto p1 = new Produto(1, "Notebook", 3500.00m, 5);
            p1.ExibirInformacoes();

            // Produto com apenas os campos essenciais
            Produto p2 = new Produto(2, "Teclado");
            p2.Preco = 150.00m;
            p2.Estoque = 10;
            p2.ExibirInformacoes();

            // Produto com construtor padrão
            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome = "Mouse";
            p3.Preco = 80.00m;
            p3.Estoque = 0; // Aqui testamos o status "Indisponível"
            p3.ExibirInformacoes();

            // Agora vou testar as validações:

            // Nome vazio (vai gerar erro)
            Produto invalido1 = new Produto(4, "");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar produto: " + ex.Message);
        }

        try
        {
            // Preço negativo (vai gerar erro)
            Produto invalido2 = new Produto(5, "Monitor");
            invalido2.Preco = -1000.00m;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao definir preço: " + ex.Message);
        }

        try
        {
            // Estoque negativo (vai gerar erro)
            Produto invalido3 = new Produto(6, "Cabo HDMI");
            invalido3.Estoque = -5;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao definir estoque: " + ex.Message);
        }
    }
}
