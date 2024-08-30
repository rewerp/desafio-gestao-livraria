using DesafioAPIGestaoLivraria.Entities;
using System.Runtime.InteropServices;

namespace DesafioAPIGestaoLivraria.Repositories;

public class LivroRepository
{
  public Dictionary<int, Livro> Livros { get; set; }
  private int Id = 0;

  public LivroRepository()
  {
    Livros = new Dictionary<int, Livro>();
  }

  public int AdicionarLivro(Livro livro)
  {
    Id++;
    livro.Id = Id;
    Livros[Id] = livro;

    return Id;
  }

  public List<Livro> ObterTodosLivros()
  {
    var listaLivros = new List<Livro>();

    foreach (var item in Livros)
    {
      listaLivros.Add(item.Value);
    }

    return listaLivros;
  }

  public Livro ObterLivroPorId(int id)
  {
    return Livros[id];
  }

  public void AtualizarLivro(int id, Livro livro)
  {
    if (livro.Titulo is not null) Livros[id].Titulo = livro.Titulo;

    if (livro.Autor is not null) Livros[id].Autor = livro.Autor;

    if (livro.Genero is not null) Livros[id].Genero = livro.Genero;

    if (livro.Preco != Livros[id].Preco && livro.Preco > 0) Livros[id].Preco = livro.Preco;

    if (livro.QuantidadeEstoque != Livros[id].QuantidadeEstoque && livro.QuantidadeEstoque >= 0) 
      Livros[id].QuantidadeEstoque = livro.QuantidadeEstoque;
  }

  public void RemoverLivro(int id)
  {
    Livros.Remove(id);
  }
}
