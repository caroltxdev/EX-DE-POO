using System;

// Professor, essa classe também herda de ArmazenamentoBase, mas simula operações de nuvem.
// O funcionamento é semelhante ao local, mas com mensagens diferentes para simular a nuvem.

public class ArmazenamentoNuvem : ArmazenamentoBase
{
    public override byte[] Carregar(string arquivo)
    {
        LogOperacao($"(Nuvem) Download do arquivo '{arquivo}'");
        return arquivos.ContainsKey(arquivo) ? arquivos[arquivo] : null;
    }

    public override void Excluir(string arquivo)
    {
        if (arquivos.Remove(arquivo))
            LogOperacao($"(Nuvem) Arquivo '{arquivo}' excluído.");
        else
            Console.WriteLine("Arquivo não encontrado na nuvem.");
    }
}
