//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

//IMPORTANTE: 
//	Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

// declaração da variável que será utilizada como input do usuário
uint numeroTeste;

// caso seja escolhido o input
Console.WriteLine("Digite um número inteiro entre 0 e 4.294.967.295");
while (!uint.TryParse(Console.ReadLine(), out numeroTeste))
{
    Console.WriteLine("Você deve digitar um número inteiro entre 0 e 4.294.967.295");
}

// caso seja codado o input
// numeroTeste = 12489102;

static bool quadradoPerfeito(uint x)
{
    uint rq = (uint)Math.Sqrt(x);
    return (rq * rq == x);
}

static bool testeDeBinet(uint x)
{
    return quadradoPerfeito(5 * ((uint)Math.Pow(x, 2)) + 4) || quadradoPerfeito(5 * ((uint)Math.Pow(x, 2)) - 4);
}

Console.WriteLine(testeDeBinet(numeroTeste) ? numeroTeste + " pertence a sequência de fibonacci!" : " NÃO pertence a sequência de fibonacci!");