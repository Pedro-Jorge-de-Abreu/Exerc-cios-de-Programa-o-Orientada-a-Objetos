public class Pagamento
{
    private int _parcelas;
    public string FormaPagamento { get; set; }

    public int Parcelas
    {
        get => _parcelas;
        set => _parcelas = value >= 1 ? value : 1;
    }

    public void ExibirDados() => Console.WriteLine($"Pagamento: {FormaPagamento} em {Parcelas}x");

    public bool ValidarPagamento() => !string.IsNullOrEmpty(FormaPagamento) && Parcelas >= 1;

    public double CalcularAcrescimo(double valorBase)
    {
        return Parcelas > 1 ? valorBase * 0.05 : 0;
    }
}