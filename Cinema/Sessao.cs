using System;
using System.Text;
namespace Cinema
{
	public class Sessao
	{
		private Filme Filme { get; set; }
		private Sala Sala { get; set; }
		private DateTime DataHora { get; set; }

		public Sessao(Sala sala, DateTime dataHora)
		{
			Sala = sala;
			DataHora = dataHora;
		}

		public void AddFilme (Filme filme)
		{
			Filme = filme;
		}

        public override string ToString()
        {
			StringBuilder builder = new StringBuilder();

			builder.AppendLine($"Nome: {Filme.Titulo} - Hora: {DataHora.ToString("HH:mm - dd/MM/yyyy")}");
			builder.AppendLine($"Sala: {Sala.Numero}");

			return builder.ToString();
        }
    }
}

