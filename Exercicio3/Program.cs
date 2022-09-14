//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//	• O menor valor de faturamento ocorrido em um dia do mês;
//	• O maior valor de faturamento ocorrido em um dia do mês;
//	• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

//IMPORTANTE:
//	a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
//  b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        // localizar e ler o arquivo json fornecido
        string arquivo = "dados.json";
        string path = Path.Combine(Environment.CurrentDirectory, @"arquivos\", arquivo);
        string jsonString = File.ReadAllText(path);

        // objetos criados para fazer a validação proposta
        FaturamentoDiario menorFaturamento = new FaturamentoDiario();
        FaturamentoDiario maiorFaturamento = new FaturamentoDiario();

        // variáveis de totalização
        uint totalDeDias = 0;
        decimal faturamentoTotal = 0;
        uint diasAcimaDaMediaMensal = 0;

        // desserialização da string json para uma lista de objetos
        var listaDeFaturamento = JsonSerializer.Deserialize<List<FaturamentoDiario>>(jsonString)!;

        // atribuir o menor faturamento como o membro 0 da lista.
        menorFaturamento = listaDeFaturamento[0];

        // loop da lista para preenchimento das variáveis de totalização
        foreach (var faturamento in listaDeFaturamento)
        {
            if (faturamento.valor == 0)
            {
                continue;
            }            
            else if (menorFaturamento.valor > faturamento.valor)
            {
                menorFaturamento.dia = faturamento.dia;
                menorFaturamento.valor = faturamento.valor;
            }
            else if (maiorFaturamento.valor < faturamento.valor)
            {
                maiorFaturamento.dia = faturamento.dia;
                maiorFaturamento.valor = faturamento.valor;
            }

            totalDeDias++;
            faturamentoTotal += faturamento.valor;
        }
        foreach (var faturamento in listaDeFaturamento)
        {
            if (faturamento.valor == 0)
            {
                continue;
            }
            else if (faturamento.valor > (faturamentoTotal/totalDeDias))
            {
                diasAcimaDaMediaMensal++;
            }
        }
        
        // resposta no console
        Console.WriteLine($"O menor faturamento ocorreu no dia {menorFaturamento.dia}, com um valor de {menorFaturamento.valor}.");
        Console.WriteLine($"O maior faturamento ocorreu no dia {maiorFaturamento.dia}, com um valor de {maiorFaturamento.valor}.");
        Console.WriteLine($"Houveram {diasAcimaDaMediaMensal} dias em que o faturamento foi superior a média mensal.");

        //O menor faturamento ocorreu no dia 14, com um valor de 373,7838.
        //O maior faturamento ocorreu no dia 16, com um valor de 48924,2448.
        //Houveram 9 dias em que o faturamento foi superior a média mensal.
    }
}

// Objeto utilizado para criação da lista desserializada
public class FaturamentoDiario
{
    public uint dia { get; set; }
    public decimal valor { get; set; }
}