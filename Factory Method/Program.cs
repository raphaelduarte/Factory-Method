using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | Subzero | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.Escolher_Personagem(escolha);
            Console.WriteLine();

            Console.WriteLine("Voce vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }  
}