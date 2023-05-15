
double[] arr = new double[5];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write("Digite um valor: ");
    arr[i] = double.Parse(Console.ReadLine());
}
static double SomaArray(double[] arr, int n)
{
    // Caso base: soma de um array vazio é zero
    if (n == 0)
    {
        return 0;
    }

    // Passo da recursão: soma do elemento atual com a soma do restante do array
    return arr[n - 1] + SomaArray(arr, n - 1);
}
