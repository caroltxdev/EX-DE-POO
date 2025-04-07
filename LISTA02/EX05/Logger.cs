using System;

public class Logger : ILogConsole, ILogArquivo
{
    // Implementação explícita de cada interface
    void ILogConsole.Log(string mensagem)
    {
        Console.WriteLine("[Console] " + mensagem);
    }

    void ILogArquivo.Log(string mensagem)
    {
        Console.WriteLine("[Arquivo] " + mensagem + " (simulado)");
    }
}