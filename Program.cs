using System;

class Program
{
    static void Main()
    {
        // Pedir ao usuário para digitar um número inteiro positivo
        Console.Write("Digite um número inteiro positivo: ");
        int N = int.Parse(Console.ReadLine());

        // Inicializar a variável soma
        int soma = 0;

        // Usando o laço for para calcular a soma dos primeiros N números
        for (int i = 1; i <= N; i++)
        {
            soma = soma + i;
        }

        // Exibir a soma
        Console.WriteLine("A soma dos primeiros " + N + " números é: " + soma);
    }
}