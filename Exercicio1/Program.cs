//1) Observe o trecho de código abaixo:

//	int INDICE = 13, SOMA = 0, K = 0;

//enquanto K < INDICE faça
//	{
//    K = K + 1;
//    SOMA = SOMA + K;
//}

//imprimir(SOMA);

//Ao final do processamento, qual será o valor da variável SOMA?


// declaração das variáveis
int indice = 13;
int soma = 0;
int k = 0;

// teste lógico
while (k < indice)
{
    k = k + 1;
    soma = soma + k;
}

// resultado
Console.WriteLine(soma);

// Resposta: Soma = 91;