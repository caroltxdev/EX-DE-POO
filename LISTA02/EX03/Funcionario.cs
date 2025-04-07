using System;

// Professor, essa é a classe base que representa qualquer funcionário da empresa.
// Coloquei as propriedades mais comuns aqui, e métodos que podem ser sobrescritos pelas classes filhas.
public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataAdmissao { get; set; }
    public decimal SalarioBase { get; set; }

    public Funcionario(string nome, string cpf, DateTime dataAdmissao, decimal salarioBase)
    {
        Nome = nome;
        CPF = cpf;
        DataAdmissao = dataAdmissao;
        SalarioBase = salarioBase;
    }

    // Método virtual: pode ser sobrescrito nas classes filhas com cálculo específico.
    public virtual decimal CalcularSalario()
    {
        return SalarioBase;
    }

    // Método virtual: exibe os dados comuns. As classes derivadas podem estender esse comportamento.
    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Data de Admissão: {DataAdmissao.ToShortDateString()}");
        Console.WriteLine($"Salário Base: R${SalarioBase:F2}");
    }
}