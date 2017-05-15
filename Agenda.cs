using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatoAgenda
{
    public class Agenda
    {
        public List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato c)
        {
            contatos.Add(c);
        }

        public void ListarTodos()
        {
            if (contatos.Count() == 0)
            {
                Console.WriteLine("Não há contatos.");
            }
            else
            {
                foreach (Contato c in contatos)
                {
                    Console.WriteLine("Nome do contato: {0} \t Telefone do contato: {1}", c.Nome, c.Telefone);
                }
            }
            
        }

        public void ListarPNome(String nome)
        {
            if (contatos.Count() == 0)
            {
                Console.WriteLine("Não há contatos.");
            }
            else
            {
                foreach (Contato c in contatos)
                {
                    if (c.Nome.ToLower().Contains(nome.ToLower()))
                    {
                        Console.WriteLine("Nome do contato: {0} \t Telefone do contato: {1}", c.Nome, c.Telefone);
                    }
                }
            }
            
        }
    }
}
