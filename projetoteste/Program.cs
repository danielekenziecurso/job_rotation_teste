using projetoteste.modeis;


class Program
{
    static void Main()
    {
        // Sequência de Fibonacci
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (MyProgram.PertenceFibonacci(numero))
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");

        // Calculadora de Faturamento
        decimal[] faturamento = { 1000.50m, 2000.75m, 1500.30m, 1800.20m, 2500.60m, 2200.45m, 3000.80m };
        var resultado = CalculadoraFaturamento.CalcularFaturamento(faturamento);
        Console.WriteLine($"Menor valor de faturamento: R${resultado.Item1:F2}");
        Console.WriteLine($"Maior valor de faturamento: R${resultado.Item2:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {resultado.Item3}");

        // Representação Percentual
        Dictionary<string, decimal> faturamentoPorEstado = new Dictionary<string, decimal>
        {
            {"SP", 67836.43m},
            {"RJ", 36678.66m},
            {"MG", 29229.88m},
            {"ES", 27165.48m},
            {"Outros", 19849.53m}
        };
        RepresentacaoPercentual.ImprimirPercentual(faturamentoPorEstado);
        
        // Definindo a string a ser invertida
        string original = "Hello, world!";
        
        // Invertendo a string
        string invertida = InverterString(original);
        
        // Imprimindo a string invertida
        Console.WriteLine("String original: " + original);
        Console.WriteLine("String invertida: " + invertida);
    }
    
    static string InverterString(string original)
    {
        // Inicializando uma variável para armazenar a string invertida
        string invertida = "";
        
        // Percorrendo a string original do fim para o início
        for (int i = original.Length - 1; i >= 0; i--)
        {
            // Concatenando cada caractere na ordem inversa à variável invertida
            invertida += original[i];
        }
        
        // Retornando a string invertida
        return invertida;
    
    }
}