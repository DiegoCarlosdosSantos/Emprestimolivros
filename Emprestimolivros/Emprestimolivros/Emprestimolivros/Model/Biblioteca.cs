using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimolivros.Model
{
    class Biblioteca
    {
        private List<Livro> livros;
        private List<Leitor> leitores;

        public Biblioteca()
        {
            livros = new List<Livro>();
            leitores = new List<Leitor>();
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void AdicionarLeitor(Leitor leitor)
        {
            leitores.Add(leitor);
        }

        public void EmprestarLivro(Leitor leitor, Livro livro)
        {
            if (!livro.Estado)
            {
                Console.WriteLine("Livro não disponível para empréstimo.");
                return;
            }

            livro.Estado = false; // Marca o livro como emprestado
            livro.LeitoresEmprestados.Add(leitor); // Adiciona o leitor à lista de leitores emprestados
            Console.WriteLine($"Livro '{livro.Titulo}' emprestado para {leitor.Nome} {leitor.Sobrenome}.");
        }

        public void DevolverLivro(Leitor leitor, Livro livro)
        {
            if (livro.Estado)
            {
                Console.WriteLine("O livro já está disponível na biblioteca.");
                return;
            }

            livro.Estado = true; // Marca o livro como disponível novamente
            livro.LeitoresEmprestados.Remove(leitor); // Remove o leitor da lista de leitores emprestados
            Console.WriteLine($"Livro '{livro.Titulo}' foi devolvido por {leitor.Nome} {leitor.Sobrenome}.");
        }

        public void ListarLivrosDisponiveis()
        {
            Console.WriteLine("Livros Disponíveis:");
            foreach (var livro in livros)
            {
                if (livro.Estado)
                    Console.WriteLine($"- {livro.Titulo} ({livro.Autor}) Nenhum leitor associado");
            }
        }

        public void ListarLivrosEmprestados()
        {
            Console.WriteLine("Livros Emprestados:");
            foreach (var livro in livros)
            {
                if (!livro.Estado && livro.LeitoresEmprestados.Count > 0)
                {
                    Console.Write($"- {livro.Titulo} ({livro.Autor}) emprestado para: ");
                    foreach (var leitor in livro.LeitoresEmprestados)
                    {
                        Console.Write($"{leitor.Nome} {leitor.Sobrenome} ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}



 


