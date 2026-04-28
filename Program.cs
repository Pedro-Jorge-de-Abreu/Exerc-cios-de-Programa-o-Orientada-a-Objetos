namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario func = new CalculadoraDeSalario();

            func.ReceberDados();
            func.MostrarSalario();
            Console.Write("Digite o percentual de AUMENTO (ex: 10): ");
            double percAumento = double.Parse(Console.ReadLine());
            func.CalcularAumento(percAumento);
            func.MostrarSalario();
            Console.Write("Digite o percentual de DESCONTO (ex: 5): ");
            double percDesconto = double.Parse(Console.ReadLine());
            func.CalcularDesconto(percDesconto); 

            func.MostrarSalario();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}