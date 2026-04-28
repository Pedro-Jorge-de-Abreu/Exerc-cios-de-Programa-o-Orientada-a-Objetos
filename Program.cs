Cliente c = new Cliente { Nome = "João Silva", Cpf = "123.456.789-00", Cidade = "São Paulo" };
Vendedor v = new Vendedor { Nome = "Robinson", PercentualComissao = 10 };
Produto p = new Produto { Descricao = "Notebook Gamer", PrecoUnitario = 5000, Quantidade = 1 };
Pagamento pag = new Pagamento { FormaPagamento = "Cartão de Crédito", Parcelas = 5 };
Entrega ent = new Entrega { Endereco = "Rua das Flores, 100", DistanciaKm = 20, TipoEntrega = "Expressa" };

Pedido meuPedido = new Pedido
{
    Cliente = c,
    Vendedor = v,
    Produto = p,
    Pagamento = pag,
    Entrega = ent
};

meuPedido.ExibirResumo();

Console.ReadKey();