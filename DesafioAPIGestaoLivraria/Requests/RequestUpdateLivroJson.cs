namespace DesafioAPIGestaoLivraria.Requests;

public class RequestUpdateLivroJson
{
  public string ?Titulo { get; set; }
  public string ?Autor { get; set; }
  public string ?Genero { get; set; }
  public double Preco { get; set; } = -1;
  public int QuantidadeEstoque { get; set; } = -1;
}
