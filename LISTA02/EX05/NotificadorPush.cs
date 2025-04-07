using System;

public class NotificadorPush : INotificador
{
    public string FormatoSuportado => "push";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        Console.WriteLine($"[PUSH] Para: {destinatario} - Mensagem: {mensagem}");
    }

    public bool ValidarDestinatario(string destinatario)
    {
        // Simulação de validação (qualquer string não vazia é válida)
        return !string.IsNullOrWhiteSpace(destinatario);
    }
}