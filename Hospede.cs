public class Hospede
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }

    public void ReceberDados()
    {
        Console.WriteLine("--- Cadastro do Hóspede ---");
        Console.Write("Nome: ");
        Nome = Console.ReadLine();
        Console.Write("CPF: ");
        Cpf = Console.ReadLine();
        Console.Write("Telefone: ");
        Telefone = Console.ReadLine();
    }

    public void MostrarDados()
    {
        Console.WriteLine("\n--- Dados do Hóspede ---");
        Console.WriteLine($"Nome: {Nome} | CPF: {Cpf} | Tel: {Telefone}");
    }

    public void AtualizarTelefone(string novoTelefone)
    {
        Telefone = novoTelefone;
        Console.WriteLine("Telefone atualizado com sucesso!");
    }
}