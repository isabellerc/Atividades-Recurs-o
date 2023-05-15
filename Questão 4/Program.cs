Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());

static string DecimalToBinary(int n)
{
    // Caso base: se o número é 0, retorna 0 em binário
    if (n == 0)
    {
        return "0";
    }

    // Passo da recursão: divide o número por 2 e converte o quociente para binário recursivamente
    int quotient = n / 2;
    string binary = DecimalToBinary(quotient);

    // Concatena o resto da divisão por 2 com o resultado da conversão recursiva
    int remainder = n % 2;
    return binary + remainder.ToString();
}

