using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digie uma operacão");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digie uma o primeiro numero");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digie uma o segundo numero");
            float num2 = float.Parse(Console.ReadLine());
            
            

            //() = Argumentos


            switch (operacao)
            {
                case "Soma":
                    Soma(num1, num2); //argumentos são separador por virgulas 
                    break;

                case "Subtração":
                    Subtrair(num1, num2);
                    break;

                default:
                    break;
            }
            
            string[] nomes = {"pedro","joao","rafael","duda","ana"};
            Listarnomes(nomes);
            
        }
        // Função ou metodo 
        static void Listarnomes(string[] mynomes)
        {
            foreach (var item in mynomes)
            {
                Console.WriteLine(item);
            }
        }

        static void Soma(float a, float b){
                Console.WriteLine("Resultado da soma");
                Console.WriteLine(a+b);
                return soma;
            }

        static void Subtrair(float a, float b){
                Console.WriteLine("Resultado da subtração");
                Console.WriteLine(a-b);
            }
    }
}
