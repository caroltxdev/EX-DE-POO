using System;
using System.Collections.Generic;

// Professor, essa é uma classe abstrata que implementa a interface.
// Aqui eu já forneço a lógica padrão para "Salvar" e "Listar",
// mas deixo "Carregar" e "Excluir" como abstratos, forçando as subclasses a personalizar.

public abstract class ArmazenamentoBase : IArmazenamento
{
    // Dicionário protegido: acessível nas classes filhas
    protected Dictionary<string, byte[]> arquivos = new();

    // Implementação padrão do método Salvar
    public virtual void Salvar(string arquivo, byte[] dados)
    {
        arquivos[arquivo] = dados;
        Console.WriteLine($"[Base] Arquivo '{arquivo}' salvo.");
    }

    // Método abstrato: a subclasse precisa dizer como vai carregar os arquivos
    public abstract byte[] Carregar(string arquivo);

    // Método abstrato: a subclasse precisa dizer como excluir
    public abstract void Excluir(string arquivo);

    // Implementação padrão para listar arquivos
    public List<string> Listar()
    {
        return new List<string>(arquivos.Keys);
    }

    // Método protegido para registrar logs que pode ser usado pelas subclasses
    protected void LogOperacao(string mensagem)
    {
        Console.WriteLine($"[LOG]: {mensagem}");
    }
}
