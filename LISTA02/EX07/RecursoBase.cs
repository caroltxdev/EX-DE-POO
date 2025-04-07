using System;

// Professor, essa é a classe base abstrata com padrão Dispose completo.
// Outras classes podem herdar e estender esse comportamento.

public abstract class RecursoBase : IDisposable
{
    private bool disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
                Console.WriteLine("[Base] Liberando recursos gerenciados.");

            Console.WriteLine("[Base] Liberando recursos não gerenciados.");

            disposed = true;
        }
    }

    ~RecursoBase()
    {
        Dispose(false);
    }
}
