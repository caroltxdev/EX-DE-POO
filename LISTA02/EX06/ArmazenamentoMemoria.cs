using System;
using System.Collections.Generic;

// Professor, essa classe implementa a interface diretamente, sem herdar da classe abstrata.
// Aqui eu mostro a diferença: preciso fazer toda a lógica do zero, sem reaproveitar nada.

public class ArmazenamentoMemoria : IArmazenamento
{
    private Dictionary<string, byte[]> _dados = new();

    public void Salvar(string arquivo, byte[] dados)
    {
        _dados[arquivo] = dados;
        Console.WriteLine($"[Memória] '{arquivo}' armazenado.");
    }

    public byte[] Carregar(string arquivo)
    {
        Console.WriteLine($"[Memória] Carregando '{arquivo}'");
        return _dados.ContainsKey(arquivo) ? _dados[arquivo] : null;
    }

    public void Excluir(string arquivo)
    {
        if (_dados.Remove(arquivo))
            Console.WriteLine($"[Memória] '{arquivo}' excluído.");
        else
            Console.WriteLine("[Memória] Arquivo não encontrado.");
    }

    public List<string> Listar()
    {
        return new List<string>(_dados.Keys);
    }
}
