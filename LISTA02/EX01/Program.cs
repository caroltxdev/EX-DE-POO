using System;

// Essa é a classe de teste. Aqui eu crio uma conta, faço algumas operações e mostro o extrato.
// Assim consigo demonstrar que o saldo está protegido e que todas as operações são registradas corretamente.

class Program
{
    static void Main(string[] args)
    {
        // Criei uma conta com titular "João Silva"
        ContaBancaria conta1 = new ContaBancaria("12345", "João Silva");

        conta1.Depositar(500);   // Depositei R$500
        conta1.Sacar(200);       // Saquei R$200
        conta1.Sacar(500);       // Tentei sacar mais do que o saldo (vai dar erro)
        conta1.Depositar(-100);  // Tentei depositar valor negativo (também dá erro)

        // Exibi o extrato com todas as transações e o saldo final
        conta1.VerExtrato();

        // Teste de segurança: isso aqui abaixo daria erro se eu tentasse descomentar:
        // conta1._saldo = 999999; // Isso não pode ser feito, porque o saldo é privado (encapsulado)
    }
}
