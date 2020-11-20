using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] nome = new string[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
            float[] nota4 = new float[10];

            string[] dados = new string[10];

            for (var contador = 0; contador <dados.Length; contador++)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Digite o nome do aluno "+contador);
                nome[contador]= Console.ReadLine();

                Console.WriteLine("Digite primeira nota do aluno "+nome[contador]);
                nota1[contador]= float.Parse(Console.ReadLine());

                Console.WriteLine("Digite segunda nota do aluno "+nome[contador]);
                nota2[contador]= float.Parse(Console.ReadLine());
    
                Console.WriteLine("Digite terceira nota do anulo "+nome[contador]);
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

            }
            
        }
        static float media()
        {
            Console.WriteLine("Media do aluno é: ");
            

        }
        
    }
    
}
