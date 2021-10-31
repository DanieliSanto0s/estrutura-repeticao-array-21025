using System;

namespace atv01_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Qual é sua idade ?");    
             idade = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("");//Espaço
            
            if (idade >= 18)
            {
                Console.WriteLine("Você tem permissão para dirigir");
            }
            else
            {
                Console.WriteLine("Você não tem permissão para dirigir");
            }
        }
    }
}
