using DesafioAPIGestaoLivraria.Entities;
using DesafioAPIGestaoLivraria.Requests;
using DesafioAPIGestaoLivraria.Responses;
using DesafioAPIGestaoLivraria.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAPIGestaoLivraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase
{
  private readonly LivroService _livroService;

  public LivroController(LivroService livroService)
  {
    _livroService = livroService;
  }

  [HttpGet]
  [ProducesResponseType(typeof(List<Livro>), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
  public IActionResult GetAll()
  {
    var response = _livroService.ObterTodosLivros();

    return Ok(response);
  }

  [HttpGet]
  [Route("{id}")]
  [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
  public IActionResult GetById([FromRoute] int id)
  {
    var response = _livroService.ObterLivroPorId(id);

    return Ok(response);
  }

  [HttpPost]
  [ProducesResponseType(typeof(Livro), StatusCodes.Status201Created)]
  [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
  public IActionResult Create([FromBody] RequestCreateLivroJson request)
  {
    var response = _livroService.AdicionarLivro(new Livro
    {
      Titulo = request.Titulo,
      Autor = request.Autor,
      Genero = request.Genero,
      Preco = request.Preco,
      QuantidadeEstoque = request.QuantidadeEstoque,
    });

    return Created(string.Empty, response);
  }

  [HttpPut]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
  public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateLivroJson request)
  {
    _livroService.AtualizarLivro(id, new Livro
    {
      Titulo = request.Titulo,
      Autor = request.Autor,
      Genero = request.Genero,
      Preco = request.Preco,
      QuantidadeEstoque = request.QuantidadeEstoque
    });

    return NoContent();
  }

  [HttpDelete]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
  public IActionResult Delete(int id)
  {
    _livroService.RemoverLivro(id);

    return NoContent();
  }
}
