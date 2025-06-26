using System;

class Program
{
    static void Main()
    {
        bool repetir = true;

        while (repetir)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine($"Resultado: {resultado}");
                repetir = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Digite um número inteiro válido.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
            }
        }
    }
}