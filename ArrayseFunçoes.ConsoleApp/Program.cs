namespace ArrayseFunçoes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AcaoUsuario();
        }
        //Desenvolver um programa que receba 10 valores inteiros,  -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 
        private static void AcaoUsuario()
        {
            int[] valores = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
            Console.WriteLine("Valores da sequência:");
            MostrarValores(valores);
            Console.WriteLine($"\nMaior valor da sequência: {EncontrarMaiorValor(valores)}");
            Console.WriteLine($"Menor valor da sequência: {EncontrarMenorValor(valores)}");
            Console.WriteLine($"Valor médio da sequência: {EncontrarValorMedio(valores)}");

            Console.WriteLine("\nOs 3 maiores valores da sequência:");
            MostrarValores(EncontrarTresMaioresValores(valores));

            Console.WriteLine("\nValores negativos da sequência:");
            MostrarValores(EncontrarValoresNegativos(valores));

            Console.WriteLine("\nInforme o valor que deseja remover da sequência:");
            int valorRemover = int.Parse(Console.ReadLine());
            valores = RemoverValor(valores, valorRemover);
            Console.WriteLine("Sequência após a remoção do valor:");
            MostrarValores(valores);
        }

        static void MostrarValores(int[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write(valores[i] + " / ");
            }
        }
        
        static int EncontrarMaiorValor(int[] valores)
        {
            int maiorValor = valores[0];
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] > maiorValor)
                {
                    maiorValor = valores[i];
                }
            }
            return maiorValor;
        }
        
        static int EncontrarMenorValor(int[] valores)
        {
            int menorValor = valores[0];
            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i] < menorValor)
                {
                    menorValor = valores[i];
                }
            }
            return menorValor;
        }
        
        static double EncontrarValorMedio(int[] valores)
        {
            int soma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            double valorMedio = (double)soma / valores.Length;
            return valorMedio;
        }

        static int[] EncontrarTresMaioresValores(int[] valores)
        {
            int[] tresMaioresValores = new int[3];
            Array.Sort(valores);
            Array.Reverse(valores);
            for (int i = 0; i < 3; i++)
            {
                tresMaioresValores[i] = valores[i];
            }
            return tresMaioresValores;
        }
        
        static int[] EncontrarValoresNegativos(int[] valores)
        {
            int numNegativos = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < 0)
                {
                    numNegativos++;
                }
            }
            int[] valoresNegativos = new int[numNegativos];
            int indice = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] < 0)
                {
                    valoresNegativos[indice] = valores[i];
                    indice++;
                }
            }
            return valoresNegativos;
        }
        
        static int[] RemoverValor(int[] valores, int valorRemover)
        {
            int numValores = valores.Length;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == valorRemover)
                {
                    numValores--;
                }
            }
            int[] valoresFinais = new int[numValores];
            int indice = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] != valorRemover)
                {
                    valoresFinais[indice] = valores[i];
                    indice++;
                }
            }
            return valoresFinais;
        }
    }
}