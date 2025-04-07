using System;

// Classe filha que herda de Funcionario.
// Professor, aqui adicionei os campos específicos de um desenvolvedor, como especialidade e nível.
public class Desenvolvedor : Funcionario
{
    public string Especialidade { get; set; }
    public string Nivel { get; set; }

    public Desenvolvedor(string nome, string cpf, DateTime dataAdmissao, decimal salarioBase,
                         string especialidade, string nivel)
        : base(nome, cpf, dataAdmissao, salarioBase)
    {
        Especialidade = especialidade;
        Nivel = nivel;
    }

    public override decimal CalcularSalario()
    {
        // Simulei um bônus de 20% para desenvolvedores
        return SalarioBase * 1.2m;
    }

    public override void ExibirDados()
    {
        base.ExibirDados(); // Chama os dados comuns do funcionário
        Console.WriteLine($"Especialidade: {Especialidade}");
        Console.WriteLine($"Nível: {Nivel}");
        Console.WriteLine($"Salário Total: R${CalcularSalario():F2}\n");
    }
}