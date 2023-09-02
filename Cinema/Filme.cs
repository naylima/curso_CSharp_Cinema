using System;
namespace Cinema
{
	public class Filme
	{
		public string Titulo { get; set; }
		public int Ano { get; set; }
		public int Duracao { get; set; }

		public Filme(string titulo, int ano, int duracao)
		{
			Titulo = titulo;
			Ano = ano;
			Duracao = duracao;
		}
	}
}

