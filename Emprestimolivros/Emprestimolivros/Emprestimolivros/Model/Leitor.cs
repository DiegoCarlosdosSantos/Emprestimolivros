using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimolivros.Model
{
    class Leitor
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Leitor(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}
