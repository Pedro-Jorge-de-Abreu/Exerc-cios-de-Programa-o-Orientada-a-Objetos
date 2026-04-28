public class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Cidade { get; set; }

    public void ExibirDados() => Console.WriteLine($"Cliente: {Nome} | CPF: {Cpf} | Cidade: {Cidade}");

    public string RetornarApresentacao() => $"O cliente {Nome}, residente em {Cidade}, portador do CPF {Cpf}.";
}