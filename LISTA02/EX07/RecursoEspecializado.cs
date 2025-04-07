using System;

// Professor, essa é uma classe que herda de RecursoBase
// e adiciona seu próprio comportamento de liberação de recursos.

public class RecursoEspecializado : RecursoBase
{
    private bool disposed = false;

    // Aqui eu estendo a liberação de recursos
    protected override void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                Console.WriteLine("[Derivada] Liberando recursos gerenciados adicionais.");
            }

            Console.WriteLine("[Derivada] Liberando recursos não gerenciados adicionais.");

            disposed = true;
        }

        // Chama o Dispose da base para liberar o que for necessário lá
        base.Dispose(disposing);
    }
}
