using DesafioAPIGestaoLivraria.Entities;
using DesafioAPIGestaoLivraria.Repositories;
using DesafioAPIGestaoLivraria.Requests;
using DesafioAPIGestaoLivraria.Responses;

namespace DesafioAPIGestaoLivraria.Services;

public class LivroService
{
  private readonly LivroRepository _livroRepository;

  public LivroService(LivroRepository livroRepository)
  {
    _livroRepository = livroRepository;
  }

  public Livro AdicionarLivro(Livro livro)
  {
    livro.Id = _livroRepository.AdicionarLivro(livro);

    return livro;
  }

  public List<Livro> ObterTodosLivros()
  {
    return _livroRepository.ObterTodosLivros();
  }

  public Livro ObterLivroPorId(int id)
  {
    return _livroRepository.ObterLivroPorId(id);
  }

  public void AtualizarLivro(int id, Livro livro)
  {
    _livroRepository.AtualizarLivro(id, livro);
  }

  public void RemoverLivro(int id)
  {
    _livroRepository.RemoverLivro(id);
  }
}
