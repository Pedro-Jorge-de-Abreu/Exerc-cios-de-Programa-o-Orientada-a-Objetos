namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria minhaConta = new ContaBancaria();

            minhaConta.ReceberDados();
            minhaConta.MostrarSaldo();

            minhaConta.Depositar();
            minhaConta.MostrarSaldo();

            minhaConta.Sacar();
            minhaConta.MostrarSaldo();

            Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}