using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatoAgenda
{
    class Program
    {
        public static Agenda agenda = new Agenda();

        static void Main(string[] args)
        {
            String op = "";
            do
            {
                Console.Clear();

                Console.Write("0. Sair   1. Adicionar   2. Listar todos   3. Buscar por nome \nEntre com a opção desejada: ");
                op = Console.ReadLine();

                Console.Clear();

                switch (op)
                {
                    case "0":
                        Sair();
                    break;
                    case "1":
                        Adicionar();
                    break;
                    case "2":
                        ListarTodos();
                    break;
                    case "3":
                        ListarPNome();
                    break;
                }
            } while (op != "0");


            Console.ReadKey();
        }


        static void Sair()
        {
            Console.WriteLine("O programa foi encerrado.");
        }

        static void Adicionar()
        {
            Console.Write("Insira o nome do contato: ");
            string nome = Console.ReadLine();

            Console.Write("Insira o telefone do contado: ");
            agenda.Adicionar(new Contato { Nome = nome, Telefone = Console.ReadLine() });

            Console.WriteLine("\nConsole adicionado com sucesso.");
        }

        static void ListarTodos()
        {
            agenda.ListarTodos();

            Console.WriteLine("\n\nPressione uma tecla para retornar.");
            Console.ReadKey();
            
        }

        static void ListarPNome()
        {
            Console.Write("Insira um nome para buscar: ");

            agenda.ListarPNome(Console.ReadLine());

            Console.WriteLine("\n\nPressione uma tecla para retornar.");
            Console.ReadKey();

        }



    }
}
