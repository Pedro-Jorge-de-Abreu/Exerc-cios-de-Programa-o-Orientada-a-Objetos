public class Pedido
{
    public int Numero => 12345;

    public Cliente Cliente { get; set; }
    public Vendedor Vendedor { get; set; }
    public Produto Produto { get; set; }
    public Pagamento Pagamento { get; set; }
    public Entrega Entrega { get; set; }

    public double CalcularValorFinal()
    {
        double subtotal = Produto.CalcularSubtotal();
        double taxa = Entrega.CalcularTaxaEntrega();
        double juros = Pagamento.CalcularAcrescimo(subtotal);
        return subtotal + taxa + juros;
    }

    public double CalcularComissaoVendedor()
        => Vendedor.CalcularComissao(CalcularValorFinal());

    public void ExibirResumo()
    {
        Console.WriteLine($"\nRESUMO DO PEDIDO Nº {Numero}");
        Cliente.ExibirDados();
        Vendedor.ExibirDados();
        Produto.ExibirDados();
        Pagamento.ExibirDados();
        Entrega.ExibirDados();
        Console.WriteLine($"VALOR FINAL DO PEDIDO: R$ {CalcularValorFinal():F2}");
        Console.WriteLine($"COMISSÃO DO VENDEDOR: R$ {CalcularComissaoVendedor():F2}");
    }
}