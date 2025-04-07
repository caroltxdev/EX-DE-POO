using System;

public class NotificadorEmail : INotificador
{
    public string FormatoSuportado => "email";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        Console.WriteLine($"[EMAIL] Para: {destinatario} - Mensagem: {mensagem}");
    }

    public bool ValidarDestinatario(string destinatario)
    {
        // Validação simples: verifica se tem "@" no e-mail
        return destinatario.Contains("@");
    }
}