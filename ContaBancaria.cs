namespace banco
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }
        public void ReceberDados()
        {
            Console.WriteLine("Cadastro de Conta");
            Console.Write("Digite o número da conta: ");
            NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            NomeTitular = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            Saldo = double.Parse(Console.ReadLine());
        }
        public void Depositar()
        {
            Console.Write("\nDigite o valor para DEPOSITAR: ");
            double valor = double.Parse(Console.ReadLine());
            Saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso!");
        }
        public void Sacar()
        {
            Console.Write("\nDigite o valor para SACAR: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("ERRO: Saldo insuficiente para esta operação.");
            }
        }
        public void MostrarSaldo()
        {
            Console.WriteLine("\nDados da Conta");
            Console.WriteLine($"Conta: {NumeroConta}");
            Console.WriteLine($"Titular: {NomeTitular}");
            Console.WriteLine($"Saldo Atual: R$ {Saldo:F2}");
        }
    }
}