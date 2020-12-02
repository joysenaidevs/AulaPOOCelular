using System;
using AulaPOOCelular.cel;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
            //- Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
            //- Só será possível executar tais métodos se o celular estiver ligado.

            Celular celular = new Celular();

            Console.WriteLine("Digite a cor do celular: ");
            celular.cor = Console.ReadLine();

            Console.WriteLine("Digite o modelo do celular: ");
            celular.modelo = Console.ReadLine();

            Console.WriteLine("Digite o tamanho do celular: ");
            celular.tamanho= Console.ReadLine();

            Console.WriteLine("Seu celular esta ligado: true/false? ");
            celular.ligado = bool.Parse(Console.ReadLine());

            int escolha = 0;

            if (celular.ligado == true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("[1] - Fazer ligação");
                Console.WriteLine("[2] - Enviar uma mensagem");
                Console.WriteLine("[3] - Desligar aparelho ");
                escolha = int.Parse(Console.ReadLine());

            }else{
                Console.WriteLine("Precisa ligar o celular");
            }

           
            


        }
    }
}
