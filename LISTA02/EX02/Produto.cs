using System;

public class Produto
{
    // Professor, aqui estou usando propriedades autoimplementadas para Código e Nome.
    // São simples e diretas, mas com validação no set de Nome mais abaixo.
    public int Codigo { get; set; }

    private string _nome;
    public string Nome
    {
        get => _nome;
        set
        {
            // Validação: o nome não pode ser nulo ou vazio.
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome do produto não pode ser vazio.");
            _nome = value;
        }
    }

    // Aqui estou usando propriedades com validação no set.
    private decimal _preco;
    public decimal Preco
    {
        get => _preco;
        set
        {
            if (value < 0)
                throw new ArgumentException("O preço não pode ser negativo.");
            _preco = value;
        }
    }

    private int _estoque;
    public int Estoque
    {
        get => _estoque;
        set
        {
            if (value < 0)
                throw new ArgumentException("O estoque não pode ser negativo.");
            _estoque = value;
        }
    }

    // Essa propriedade é somente leitura, porque a data de cadastro não deve mudar após ser definida.
    public DateTime DataCadastro { get; }

    // Aqui estou implementando uma propriedade calculada.
    // Valor total que existe em estoque (Preço x Quantidade)
    public decimal ValorEmEstoque => Preco * Estoque;

    // Outra propriedade calculada: retorna "Disponível" se houver estoque, ou "Indisponível"
    public string Status => Estoque > 0 ? "Disponível" : "Indisponível";

    // Construtor completo
    public Produto(int codigo, string nome, decimal preco, int estoque)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        DataCadastro = DateTime.Now; // Definida no momento da criação
    }

    // Construtor com apenas os atributos essenciais
    public Produto(int codigo, string nome)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = 0;           // Defino o resto como zero por padrão
        Estoque = 0;
        DataCadastro = DateTime.Now;
    }

    // Construtor padrão (caso seja necessário usar inicialização posterior)
    public Produto()
    {
        DataCadastro = DateTime.Now;
    }

    // Método auxiliar para exibir o produto
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R${Preco:F2}");
        Console.WriteLine($"Estoque: {Estoque}");
        Console.WriteLine($"Valor em Estoque: R${ValorEmEstoque:F2}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Data de Cadastro: {DataCadastro}");
        Console.WriteLine();
    }
}