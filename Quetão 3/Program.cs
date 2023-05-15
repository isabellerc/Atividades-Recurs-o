double[] arr = new double[5];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write("Digite um valor: ");
    arr[i] = double.Parse(Console.ReadLine());
}

static void ReverseArray(int[] arr, int start, int end)
{
    // Caso base: se o início é maior ou igual ao fim, não há mais elementos a serem invertidos
    if (start >= end)
    {
        return;
    }

    // Passo da recursão: troca o elemento do início com o elemento do fim e chama a função recursivamente
    int temp = arr[start];
    arr[start] = arr[end];
    arr[end] = temp;
    ReverseArray(arr, start + 1, end - 1);
}
