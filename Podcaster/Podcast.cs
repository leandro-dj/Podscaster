using System;
using System.Collections.Generic;

using System.Runtime.Intrinsics.Arm;

namespace Podcaster
{
    internal class Podcast
    {
        public int Id { get; private set; }
        private static int ultimoId = 0;
        public Podcast()
        {
               
            Episodios = new List<Episodio>();

            ultimoId++;
            this.Id = ultimoId;
        }

        public string Nome { get; set; }
        public string Host { get; set; }
    
      
        public List<Episodio> Episodios { get; set; }
        
        public int TotalEpisodio => Episodios.Count;

        public List<Episodio> TodosEpisodios()
        {
            return Episodios.ToList();
        }



        public void AdicionarEpisodio(Episodio episodio)
        {

            Episodios.Add(episodio);

            Console.WriteLine();
            Console.WriteLine("Episódio adicionado com sucesso!");
        }



        public string ExibirDetalhes()
        {
            return $"O Podcast {Nome} apresentado por {Host} já contém {TotalEpisodio} episódios de graça para baixar. ";
                                

           
        }


    }


}