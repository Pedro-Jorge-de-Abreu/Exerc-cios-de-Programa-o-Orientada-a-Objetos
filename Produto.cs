public class Produto
{
    private double _precoUnitario;
    private int _quantidade;

    public string Descricao { get; set; }

    public double PrecoUnitario
    {
        get => _precoUnitario;
        set => _precoUnitario = value < 0 ? 0 : value;
    }

    public int Quantidade
    {
        get => _quantidade;
        set => _quantidade = value > 0 ? value : 1;
    }

    public void ExibirDados() => Console.WriteLine($"Produto: {Descricao} | Preço: R${PrecoUnitario:F2} | Qtd: {Quantidade}");

    public double CalcularSubtotal() => PrecoUnitario * Quantidade;
}