using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE RH ===\n");

        // Professor, aqui eu criei uma lista de funcionários do tipo base.
        // Mas com objetos de tipos diferentes (polimorfismo em ação).
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Desenvolvedor("Ana", "123.456.789-00", DateTime.Parse("2020-01-10"), 6000, "Back-end", "Pleno"),
            new Gerente("Carlos", "987.654.321-00", DateTime.Parse("2018-03-15"), 9000, 10, 2000),
            new Atendente("João", "111.222.333-44", DateTime.Parse("2022-08-01"), 2000, 100, 5)
        };

        Console.WriteLine("=== FOLHA DE PAGAMENTO ===\n");

        // Aqui uso o polimorfismo para chamar os métodos corretos, mesmo usando o tipo base.
        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirDados();
        }
    }
}