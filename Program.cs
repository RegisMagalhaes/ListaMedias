using System;

namespace reforco
{
    class Program
    {
        static void Main(string[] args)
        {
            static float CalculoMedia( float[] numeros) {

                float soma = 0;

                for (var i = 0; i < numeros.Length; i++)
                {
                    soma += numeros[i];
                }

                float resultado = soma / numeros.Length;

                return resultado;
            }

            /*Faça um programa que receba o nome e quatro notas de 10 alunos e
            armazene essas notas em vetores. Calcule e mostre: 
            a) A média do aluno - use função
            b) a quantidade de aprovados (Media >=7)
            c) a quantidade de reprovados (Media < 7)
            d) A media geral dos 10 alunos */

            // Criar as variáveis necessárias

            string[]nomes = new string[2];
            float[]medias = new float[2];
            float[]notas = new float[3];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o nome de um aluno: ");
                nomes[i] = Console.ReadLine();

                for (var n = 0; n < notas.Length; n++)
                {
                   Console.WriteLine("Digite a" +(n+1)+ "º nota");
                   notas[n] = float.Parse(Console.ReadLine());
                }
                
                //medias[i] = (notas[0] + notas[1] + notas[2] + notas[3])/4;
                medias[i] = CalculoMedia(notas);
            }

            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($" Nome: {nomes[i]} Media:{medias[i]}");
            }

            Console.WriteLine("Media Geral da Turma: " + CalculoMedia(medias));

            Console.ResetColor();
        }

    }
}
