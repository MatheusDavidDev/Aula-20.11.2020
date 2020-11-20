using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] nomes = {"m","a","k","g"};
            // 0 1 2 3 4

            //    Console.WriteLine(nomes[4]);

            // string[] nomes = new string[4];

            // nomes[0] = "";
            // nomes[1] = "";
            // nomes[2] = "";

            //     Console.WriteLine(nomes[4]);

            // string[] nomes = new string[10];
            // int[] idade = new int[10];
            // string[] rg = new string[10];
            // string[] cpf = new string[10];

            // string[] nomes = {"pedro","joao","rafael","duda","ana"};
            // //                  0       1       2       3      4
            // // cria a repetição 
            // for (var i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(nomes[i]);
            // }

            // //while ao chegar no "objetivo" oq ele vai fazer

            // int idade = 18;
            // float altura = 1.80f;
            // while (idade < 18 && altura < 1.90)
            // {
            //     Console.WriteLine("você precisa ser mais alto e mais velho");
            // }
            // //

            // //a diferença para o while é que o do sempre executa antes da condição
            // string senha;
            // do
            // {
            //     Console.WriteLine("Digite sua senha");
            //     Console.ReadLine();
            // } while (senha != "12345");

            // Console.WriteLine("Você esta logado");
            // //

            // //Switch 
            // string estado = Console.ReadLine();

            // switch (estado)
            // {
            //     case "SP":
            //         Console.WriteLine("São paulo - ligue para: 11-9999-9999");
            //         break;

            //     case "RJ":
            //         Console.WriteLine("Rio de janeiro - ligue para: 21-00000-000");
            //         break;

            //     default:
            //         Console.WriteLine("Não atendemos esse estado");
            //         break;
            // }

            //foreach
            //executa quantidade de itens que eu tenho do meu array  array = variavel

            string[] nomes = {"pedro","joao","rafael","duda","ana"};
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            

        }
    }
}
