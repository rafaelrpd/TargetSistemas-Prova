//5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//	a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//  b) Evite usar funções prontas, como, por exemplo, reverse;

// solicitação de input
Console.Write("Digite uma palavra: ");
string inputUsuario = Console.ReadLine();

// input codado
// inputUsuario = "Target Sistemas";

// declaração das variáveis de transição e contagem
char[] arrayDeChars = new char[inputUsuario.Length];
int j = 0;

// loop que fará a inversão
for (int i = inputUsuario.Length - 1; i >= 0; i--)
{
    arrayDeChars[j++] = inputUsuario[i];
}

Console.WriteLine(new string(arrayDeChars));

