public class Reserva
{
    public int NumeroReserva { get; set; }
    public int QuantidadeDiarias { get; set; }
    public double ValorDiaria { get; set; }
    public double ValorTotal { get; set; }

    public void ReceberDadosReserva()
    {
        Console.WriteLine("\n--- Dados da Reserva ---");
        Console.Write("Número da Reserva: ");
        NumeroReserva = int.Parse(Console.ReadLine());
        Console.Write("Quantidade de Diárias: ");
        QuantidadeDiarias = int.Parse(Console.ReadLine());
        Console.Write("Valor da Diária: ");
        ValorDiaria = double.Parse(Console.ReadLine());
    }

    public void CalcularTotal() => ValorTotal = QuantidadeDiarias * ValorDiaria;

    public void AplicarDesconto(double percentual)
    {
        double desconto = ValorTotal * (percentual / 100);
        ValorTotal -= desconto;
        Console.WriteLine($"Desconto de {percentual}% aplicado.");
    }

    public void MostrarReserva()
    {
        Console.WriteLine("\n--- Resumo da Reserva ---");
        Console.WriteLine($"Reserva nº: {NumeroReserva} | Total: R$ {ValorTotal:F2}");
    }
}