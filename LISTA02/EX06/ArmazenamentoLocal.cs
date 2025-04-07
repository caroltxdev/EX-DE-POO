using System;

// Professor, essa é uma classe concreta que herda de ArmazenamentoBase.
// Aqui eu aproveito a implementação padrão e personalizo só o que é necessário.

public class ArmazenamentoLocal : ArmazenamentoBase
{
    public override byte[] Carregar(string arquivo)
    {
        LogOperacao($"Carregando arquivo local '{arquivo}'");
        return arquivos.ContainsKey(arquivo) ? arquivos[arquivo] : null;
    }

    public override void Excluir(string arquivo)
    {
        if (arquivos.Remove(arquivo))
            LogOperacao($"Arquivo local '{arquivo}' excluído.");
        else
            Console.WriteLine("Arquivo não encontrado.");
    }
}
