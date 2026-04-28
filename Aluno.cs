namespace SistemaEscolar
{
    public class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public double NotaProva { get; set; }
        public double NotaTrabalho { get; set; }
        public double NotaFinal { get; set; }

        public void ReceberDados()
        {
            Console.Write("Digite o RA: ");
            RA = Console.ReadLine();

            Console.Write("Digite o Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite a Nota da Prova: ");
            NotaProva = double.Parse(Console.ReadLine());

            Console.Write("Digite a Nota do Trabalho: ");
            NotaTrabalho = double.Parse(Console.ReadLine());
        }

        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;
        }

        public bool CalcularNotaFinal()
        {
            if (NotaFinal >= 6.0)
            {
                Console.WriteLine("Aluno aprovado diretamente!");
                return true;
            }
            else
            {
                double necessaria = 10.0 - NotaFinal;
                Console.WriteLine($"O aluno precisa de {necessaria:F2} na prova final.");
                return false;
            }
        }

        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"\nNota Final (Média): {NotaFinal:F2}");
        }
    }
}