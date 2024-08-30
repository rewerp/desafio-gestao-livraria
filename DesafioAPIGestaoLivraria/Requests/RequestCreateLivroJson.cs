﻿namespace DesafioAPIGestaoLivraria.Requests;

public class RequestCreateLivroJson
{
  public string Titulo { get; set; } = string.Empty;
  public string Autor { get; set; } = string.Empty;
  public string Genero { get; set; } = string.Empty;
  public double Preco { get; set; }
  public int QuantidadeEstoque { get; set; }
}