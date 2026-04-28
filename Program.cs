namespace CriarProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();

            prod.ReceberDados();
            prod.MostrarProduto();

            prod.AdicionarEstoque();
            prod.MostrarProduto();

            prod.RemoverEstoque();
            prod.MostrarProduto();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}