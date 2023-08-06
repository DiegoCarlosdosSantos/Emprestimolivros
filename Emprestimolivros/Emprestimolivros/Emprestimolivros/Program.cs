using Emprestimolivros.Model;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        // Criando alguns livros e leitores
        Livro livro1 = new Livro("Livro 1", "Autor 1");
        Livro livro2 = new Livro("Livro 2", "Autor 2");
        Livro livro3 = new Livro("Livro 3", "Autor 3");

        Leitor leitor1 = new Leitor("João", "Silva");
        Leitor leitor2 = new Leitor("Maria", "Souza");

        // Adicionando os livros e leitores à biblioteca
        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);

        biblioteca.AdicionarLeitor(leitor1);
        biblioteca.AdicionarLeitor(leitor2);

        // Fazendo empréstimos e devoluções
        biblioteca.EmprestarLivro(leitor1, livro1);
        biblioteca.EmprestarLivro(leitor2, livro2);

        biblioteca.DevolverLivro(leitor1, livro1);

        // Listando os livros disponíveis e emprestados
        biblioteca.ListarLivrosDisponiveis();
        biblioteca.ListarLivrosEmprestados();
    }

}