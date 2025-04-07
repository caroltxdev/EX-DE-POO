// Professor, essa é a interface principal que define o contrato para qualquer notificador.
// Qualquer classe que implementar isso vai ser obrigada a definir como validar, enviar e informar o formato suportado.

public interface INotificador
{
    void EnviarNotificacao(string destinatario, string mensagem);
    bool ValidarDestinatario(string destinatario);
    string FormatoSuportado { get; }
}