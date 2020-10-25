using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Informe número maior do que zero");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero > 0)
            {
                Console.WriteLine(DevolveMaiorNumero(numero));
            }
            else
            {
                Console.WriteLine("É necessário digitar um número maior do que zero");
            }           
        }

        public static int DevolveMaiorNumero(int numero)
        {
            int tamanho = numero.ToString().Length;

            int[] digitos = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                digitos[i] = numero % 10;
                numero = numero / 10;
            }

            Array.Sort(digitos);

            int valorDescendente = 0;
            for (int i = tamanho - 1; i >= 0; i--)
            {
                valorDescendente = valorDescendente * 10 + digitos[i];
            }

             return valorDescendente;
        }
    }
}
