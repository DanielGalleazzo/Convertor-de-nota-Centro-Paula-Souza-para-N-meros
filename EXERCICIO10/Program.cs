using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        
        Console.Write("Digite a primeira nota do aluno(a) ");
        string nota1 = Console.ReadLine().ToUpper(); 

        Console.Write("Digite a segunda nota do aluno(a) ");
        string nota2 = Console.ReadLine().ToUpper();

        Console.Write("Digite a terceira nota do aluno(a) ");
        string nota3 = Console.ReadLine().ToUpper();

        Console.Write("Digite a quarta nota do aluno(a) ");
        string nota4 = Console.ReadLine().ToUpper();

        
        double numNota1 = letraparanumero(nota1);
        double numNota2 = letraparanumero(nota2);
        double numNota3 = letraparanumero(nota3);
        double numNota4 = letraparanumero(nota4);

        
        double media = (numNota1 + numNota2 + numNota3 + numNota4) / 4;
        
        
        Console.WriteLine($"A média das notas é: " + media );  


        

    }
    

    
     static double letraparanumero(string nota)
    {
        switch (nota)
        {
            case "MB":
                return 10;
            case "B":
                return 8;
            case "R":
                return 5;
            case "I":
                return 3;
            default:
                return 0;
        }
    }
}
// mb b mb mb