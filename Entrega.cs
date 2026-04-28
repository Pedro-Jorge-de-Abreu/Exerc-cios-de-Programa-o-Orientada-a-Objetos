public class Entrega
{
    private double _distanciaKm;
    public string Endereco { get; set; }
    public string TipoEntrega { get; set; }

    public double DistanciaKm
    {
        get => _distanciaKm;
        set => _distanciaKm = value < 0 ? 0 : value;
    }

    public void ExibirDados() => Console.WriteLine($"Entrega: {Endereco} | Distância: {DistanciaKm}km | Tipo: {TipoEntrega}");

    public double CalcularTaxaEntrega() => DistanciaKm * 1.50; 
}