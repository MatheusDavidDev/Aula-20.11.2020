using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] nome = new string[3];
            float[] nota1 = new float[3];
            float[] nota2 = new float[3];
            float[] nota3 = new float[3];
            float[] nota4 = new float[3];
            string[] dados = new string[3];

            for (var contador = 0; contador <dados.Length; contador++)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Digite o nome do aluno "+contador);
                nome[contador]= Console.ReadLine();

                Console.WriteLine("Digite primeira nota do aluno "+nome[contador]);
                nota1[contador]= float.Parse(Console.ReadLine());

                Console.WriteLine("Digite segunda nota do aluno "+nome[contador]);
                nota2[contador]= float.Parse(Console.ReadLine());
    
                Console.WriteLine("Digite terceira nota do aluno "+nome[contador]);
                nota3[contador]= float.Parse(Console.ReadLine());

                Console.WriteLine("Digite quarta nota do aluno "+nome[contador]);
                nota4[contador]= float.Parse(Console.ReadLine());

            }  

            for (var contador = 0; contador < dados.Length; contador++)
            {
                Console.WriteLine(nome[contador]);
                Console.Write(" nota 1: "+nota1[contador]);
                Console.Write(" nota 2: "+nota2[contador]);
                Console.Write(" nota 3: "+nota3[contador]);
                Console.Write(" nota 4: "+nota4[contador]);
                Console.WriteLine(" -");
                
            }
            
            float[] media = new float[3];
            for (int contador = 0; contador < dados.Length; contador++)
            {
                Console.WriteLine("----------------");
                media[contador] = (nota1[contador] + nota2[contador] + nota3[contador] + nota4[contador]) /4;
                Console.Write($"{nome[contador]} sua media é de: {media[contador]}");

                if (media[contador] >=7 )
                {
                    Console.WriteLine(" - O aluno(a) foi APROVADO");
                }else
                {
                    Console.WriteLine(" - O aluno(a) esta REPROVADO");
                }    
                
            }
            
            float soma = 0;

            for (var contador = 0; contador < dados.Length; contador++)
            {
                soma = soma + media[contador];
            }
            
            float mediaSala = soma /3;
            Console.WriteLine("----------------");
            Console.WriteLine($"A media da sala e de: {mediaSala}");
        }

        
    }
    
}
