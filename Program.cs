using System;

namespace Estruturas_de_Repetição2
{
    class Program
    {
        static void Main(string[] args)
        {
          string nome;
          string senha;

            do{
            Console.WriteLine("Bem Vindo! Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();
            
                if(senha == nome){
                    Console.Write("Sua senha não pode ser a mesma que seu nome de usuário!");
                }
            } while(senha == nome);
            Console.WriteLine("Senha Válida");
           
        }
    }
}
