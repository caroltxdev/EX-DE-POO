using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE NOTIFICAÇÕES ===\n");

        // Instancio o gerenciador e os canais
        var gerenciador = new GerenciadorNotificacoes();

        gerenciador.RegistrarNotificador(new NotificadorEmail());
        gerenciador.RegistrarNotificador(new NotificadorSMS());
        gerenciador.RegistrarNotificador(new NotificadorPush());

        // Enviar uma notificação por todos os canais
        gerenciador.EnviarParaTodos("usuario@exemplo.com", "Seja bem-vindo!");

        // Enviar por canal específico (polimorfismo com interfaces)
        gerenciador.EnviarPorTipo("sms", "61999998888", "Código de verificação");

        // Testando implementação explícita com interfaces de log
        Console.WriteLine("\n=== TESTE DE INTERFACES COM MÉTODOS IGUAIS ===");

        Logger logger = new Logger();

        // Conversão explícita para acessar os métodos
        ((ILogConsole)logger).Log("Mensagem via console");
        ((ILogArquivo)logger).Log("Mensagem via arquivo");
    }
}

