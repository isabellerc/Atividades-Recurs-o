Console.Write("Digite um valor para x: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Digite um valor para n: ");
int n = int.Parse(Console.ReadLine());

static int Power(int x, int n)
{

    // Caso base: x^0 = 1
    if (n == 0)
    {
        return 1;
    }
    else if (n % 2 == 0)
    {
        int y = Power(x, n / 2);
        return y * y;
    }
    else
    {
        // Passo da recursão: x^n = x * x^(n-1)
        int y = Power(x, (n - 1) / 2);
        return x * y * y;
    }
}

