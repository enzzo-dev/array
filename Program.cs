using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array e vetores");  

            string[] nome = new string[5];
            int[] idade = new int[5];     

            for(var contador = 0 ; contador < 5; contador++)
            {
                Console.WriteLine($"Digite o {contador+1}° nome: ");
                nome[contador] = Console.ReadLine();
                Console.WriteLine($"Digite a idade do(a) {nome[contador]}");
                idade[contador] = int.Parse(Console.ReadLine());
            }

                Console.WriteLine("Nomes cadastrados: ");
                Console.WriteLine("Idade das pessoas cadastradas: ");

            for( var contador = 0 ; contador < 5 ; contador++)
            {
                Console.WriteLine($"{contador}° nome: {nome[contador]}");
                Console.WriteLine("idade: " +idade[contador]);
            }

        }
    }
}
