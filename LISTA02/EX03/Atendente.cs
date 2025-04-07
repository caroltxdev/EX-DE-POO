using System;

// Professor, o atendente recebe comissão baseada no número de atendimentos.
public class Atendente : Funcionario
{
    public int MetaAtendimentos { get; set; }
    public decimal ComissaoPorAtendimento { get; set; }

    public Atendente(string nome, string cpf, DateTime dataAdmissao, decimal salarioBase,
                     int metaAtendimentos, decimal comissaoPorAtendimento)
        : base(nome, cpf, dataAdmissao, salarioBase)
    {
        MetaAtendimentos = metaAtendimentos;
        ComissaoPorAtendimento = comissaoPorAtendimento;
    }

    public override decimal CalcularSalario()
    {
        return SalarioBase + (MetaAtendimentos * ComissaoPorAtendimento);
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Meta de Atendimentos: {MetaAtendimentos}");
        Console.WriteLine($"Comissão por Atendimento: R${ComissaoPorAtendimento:F2}");
        Console.WriteLine($"Salário Total: R${CalcularSalario():F2}\n");
    }
}