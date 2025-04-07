using System;

public class NotificadorSMS : INotificador
{
    public string FormatoSuportado => "sms";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        Console.WriteLine($"[SMS] Para: {destinatario} - Mensagem: {mensagem}");
    }

    public bool ValidarDestinatario(string destinatario)
    {
        // Verifica se o número tem 11 dígitos
        return destinatario.Length == 11;
    }
}