using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimolivros.Model
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Estado { get; set; } // true para disponível, false para emprestado
        public List<Leitor> LeitoresEmprestados { get; set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Estado = true; // Livro inicia disponível por padrão
            LeitoresEmprestados = new List<Leitor>();
        }
    }

}
