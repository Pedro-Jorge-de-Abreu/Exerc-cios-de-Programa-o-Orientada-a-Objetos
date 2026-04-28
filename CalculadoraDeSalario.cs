namespace CalculoSalario
{
    public class CalculadoraDeSalario
    {
        public string NomeFuncionario { get; set; }
        public double SalarioBase { get; set; }
        public double SalarioFinal { get; set; }
        public void ReceberDados()
        {
            Console.WriteLine("Cadastro de Funcionário");
            Console.Write("Nome do Funcionário: ");
            NomeFuncionario = Console.ReadLine();

            Console.Write("Salário Base: ");
            SalarioBase = double.Parse(Console.ReadLine());
            SalarioFinal = SalarioBase;
        }
        public void CalcularAumento(double percentual)
        {
            double aumento = SalarioBase * (percentual / 100);
            SalarioFinal += aumento;
            Console.WriteLine($"Aumento de {percentual}% aplicado.");
        }
        public void CalcularDesconto(double percentual)
        {
            double desconto = SalarioBase * (percentual / 100);
            SalarioFinal -= desconto;
            Console.WriteLine($"Desconto de {percentual}% aplicado.");
        }
        public void MostrarSalario()
        {
            Console.WriteLine("\nResumo Salarial");
            Console.WriteLine($"Funcionário:  {NomeFuncionario}");
            Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
            Console.WriteLine($"Salário Final: R$ {SalarioFinal:F2}");
        }
    }
}