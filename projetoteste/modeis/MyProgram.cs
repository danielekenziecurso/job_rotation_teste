
namespace projetoteste.modeis
{
    public class MyProgram
    { public static bool PertenceFibonacci(int n)
    {
        int a = 0, b = 1;
        while (b < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == n;
    }

    }
    public class CalculadoraFaturamento
    {
        public static (decimal, decimal, int) CalcularFaturamento(decimal[] faturamento)
        {
            decimal minimo = faturamento.Min();
            decimal maximo = faturamento.Max();
            decimal media = faturamento.Sum() / faturamento.Length;
            int acimaDaMedia = faturamento.Count(valor => valor > media);
            return (minimo, maximo, acimaDaMedia);
        }
    }
    public class RepresentacaoPercentual
    {
        public static void ImprimirPercentual(Dictionary<string, decimal> faturamentoPorEstado)
        {
            decimal totalMensal = faturamentoPorEstado.Values.Sum();

            foreach (var estado in faturamentoPorEstado)
            {
                decimal percentual = (estado.Value / totalMensal) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }
        }
    }
}