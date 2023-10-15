using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcaster
{
    internal class PodCaster
    {

        public PodCaster() {
            Podcasts = new List<Podcast>();
        }  

        public List<Podcast> Podcasts { get; set; }


        public List<Podcast> ListarTodosPodcasts()
        {
            return Podcasts.ToList();
        }


        public void AdicionarPodcast(Podcast podcast)
        {

           Podcasts.Add(podcast);

            Console.WriteLine();
            Console.WriteLine("Podcast adicionado com sucesso!");
        }

    }
}
