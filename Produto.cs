namespace CriarProduto
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public void ReceberDados()
        {
            Console.WriteLine("Cadastro de Produto");
            Console.Write("Código do Produto: ");
            CodigoProduto = int.Parse(Console.ReadLine());

            Console.Write("Nome do Produto: ");
            NomeProduto = Console.ReadLine();

            Console.Write("Preço: ");
            Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade Inicial em Estoque: ");
            QuantidadeEstoque = int.Parse(Console.ReadLine());
        }

        public void AdicionarEstoque()
        {
            Console.Write($"\nDigite a quantidade de '{NomeProduto}' para ADICIONAR: ");
            int quantidade = int.Parse(Console.ReadLine());
            QuantidadeEstoque += quantidade;
            Console.WriteLine("Estoque atualizado com sucesso!");
        }

        public void RemoverEstoque()
        {
            Console.Write($"\nDigite a quantidade de '{NomeProduto}' para REMOVER: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= QuantidadeEstoque)
            {
                QuantidadeEstoque -= quantidade;
                Console.WriteLine("Remoção realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("ERRO: Quantidade insuficiente em estoque.");
            }
        }

        public void MostrarProduto()
        {
            Console.WriteLine("\nDados do Produto");
            Console.WriteLine($"Código: {CodigoProduto}");
            Console.WriteLine($"Nome:   {NomeProduto}");
            Console.WriteLine($"Preço:  R$ {Preco:F2}");
            Console.WriteLine($"Estoque Atual: {QuantidadeEstoque} unidades");
        }
    }
}