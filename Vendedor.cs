public class Vendedor
{
    private double _percentualComissao;
    public string Nome { get; set; }

    public string Matricula => Nome + "10";

    public double PercentualComissao
    {
        get => _percentualComissao;
        set => _percentualComissao = value < 0 ? 0 : value;
    }

    public void ExibirDados() => Console.WriteLine($"Vendedor: {Nome} | Matrícula: {Matricula} | Comissão: {PercentualComissao}%");

    public double CalcularComissao(double valorPedido) => valorPedido * (PercentualComissao / 100);
}