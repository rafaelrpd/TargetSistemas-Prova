//4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//	  SP – R$67.836,43
//    RJ – R$36.678,66
//    MG – R$29.229,88
//    ES – R$27.165,48
//    Outros – R$19.849,53
//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

internal class Program
{
    private static void Main(string[] args)
    {
        // variáveis de totalização
        double totalFaturado = 0;

        // lista de estados e faturamentos
        List<FaturamentoPorEstado> listaDeFaturamentos = new List<FaturamentoPorEstado>()
        {
            new FaturamentoPorEstado("SP", 67836.43),
            new FaturamentoPorEstado("RJ", 36678.66),
            new FaturamentoPorEstado("MG", 29229.88),
            new FaturamentoPorEstado("ES", 27165.48),
            new FaturamentoPorEstado("OUTROS", 19849.53)
        };

        // totalizador
        totalFaturado = listaDeFaturamentos.Sum(f => f.Valor);

        // loops para execução do problema proposto.        
        foreach (var estado in listaDeFaturamentos)
        {
            Console.WriteLine($"{estado.Sigla} teve um faturamento de {estado.Valor / totalFaturado,1:P} do total mensal da distribuidora.");
        }

        // Solução
        //SP teve um faturamento de 37,53 % do total mensal da distribuidora.
        //RJ teve um faturamento de 20,29 % do total mensal da distribuidora.
        //MG teve um faturamento de 16,17 % do total mensal da distribuidora.
        //ES teve um faturamento de 15,03 % do total mensal da distribuidora.
        //OUTROS teve um faturamento de 10,98 % do total mensal da distribuidora.
    }
}

// objeto que mapeará cada estado e seu respectivo faturamento.
public class FaturamentoPorEstado
{
    public FaturamentoPorEstado(string sigla, double valor)
    {
        Sigla = sigla;
        Valor = valor;
    }

    public string Sigla { get; set; }
    public double Valor { get; set; }
}