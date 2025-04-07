using System;
using System.Collections.Generic;
using System.Linq;

// Professor, essa classe gerencia todos os canais de notificação.
// Podemos registrar quantos quisermos e enviar por todos ou por tipo.

public class GerenciadorNotificacoes
{
    private List<INotificador> _notificadores = new List<INotificador>();

    // Método para registrar qualquer tipo de notificador
    public void RegistrarNotificador(INotificador notificador)
    {
        _notificadores.Add(notificador);
    }

    // Envia a mesma mensagem para todos os canais registrados
    public void EnviarParaTodos(string destinatario, string mensagem)
    {
        foreach (var notificador in _notificadores)
        {
            if (notificador.ValidarDestinatario(destinatario))
            {
                notificador.EnviarNotificacao(destinatario, mensagem);
            }
            else
            {
                Console.WriteLine($"[ERRO] Destinatário inválido para {notificador.FormatoSuportado}");
            }
        }
    }

    // Envia a mensagem apenas para o canal especificado (email, sms, push)
    public void EnviarPorTipo(string tipo, string destinatario, string mensagem)
    {
        var canal = _notificadores.FirstOrDefault(n => n.FormatoSuportado.ToLower() == tipo.ToLower());
        if (canal != null && canal.ValidarDestinatario(destinatario))
        {
            canal.EnviarNotificacao(destinatario, mensagem);
        }
        else
        {
            Console.WriteLine($"[ERRO] Tipo não encontrado ou destinatário inválido: {tipo}");
        }
    }
}