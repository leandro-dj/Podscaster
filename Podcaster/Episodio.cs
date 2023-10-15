using System;
using System.Collections.Generic;

namespace Podcaster
{
    internal class Episodio
    {
        public int Duracao { get; set; }
        public int Ordem { get; set; }
        public string Resumo { get; set; }
        public string Titulo { get; set; }

        public List<string> Convidados { get; set; } = new List<string>();
        public string Host { get; internal set; }
        public string Nome { get; internal set; }

        public void AdicionarConvidado(string nomeConvidado)
        {
            Convidados.Add(nomeConvidado);
            Console.WriteLine($"Convidado {nomeConvidado} adicionado ao episódio {Titulo}.");
        }

      
    }
}