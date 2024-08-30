namespace DesafioAPIGestaoLivraria.Responses;

public class ResponseLivroJson
{
  public int Id { get; set; }
  public string Titulo { get; set; } = string.Empty;
  public string Autor { get; set; } = string.Empty;
  public string Genero { get; set; } = string.Empty;
  public double Preco { get; set; }
  public int QuantidadeEstoque { get; set; }
}
