using Podcaster;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace exercicio
{
    class Program
    {

        static void Main()
        {

            // Criando instâncias de podcasts
            PodCaster podCaster = new PodCaster();

            Podcast podcast123 = new Podcast();

            while (true)//loop para exibir o menu
            {
                Console.Clear();

                Console.WriteLine("//////Menu Podcast////// ");
                Console.WriteLine();
                if (!podCaster.ListarTodosPodcasts().Any())
                {
                    Console.WriteLine("1 - Adicionar Podcast");
                }
                else
                {

                    Console.WriteLine("1 - Adicionar Podcast");
                    Console.WriteLine("  2 - Adicionar Episódio");
                    Console.WriteLine("      3 - Visualisar todos episódios disponiveis");
                    Console.WriteLine("         4 - Sair ");
                    Console.WriteLine();
                    Console.Write("Escolha uma opção: ");
                }


                string escolha = Console.ReadLine();

                switch (escolha)
                {

                    case "1":

                        Podcast podcast = new Podcast();


                        // Adicionar podcast
                        Console.WriteLine("Adicionar Podcast:");

                        Console.Write("Nome do Podcast: ");
                        podcast.Nome = Console.ReadLine();

                        Console.Write("Apresentador do Podcast: ");
                        podcast.Host = Console.ReadLine();

                        podCaster.AdicionarPodcast(podcast);

                        break;


                    case "2":

                        Console.WriteLine("Escolha um Podcast: ");
                        Console.WriteLine();


                        if (!podCaster.ListarTodosPodcasts().Any())
                        {
                            Console.WriteLine("Nenhum podcast cadastrado");

                            break;
                        }

                        foreach (Podcast pod in podCaster.ListarTodosPodcasts())
                        {

                            Console.WriteLine(pod.Id + ": " + pod.Nome + " Apresentado por: " + pod.Host);

                        }

                        int podcastId = int.Parse(Console.ReadLine());
                        Console.ReadKey();

                        Console.WriteLine();

                        Podcast podcastEscolhido = podCaster.Podcasts.Where(pod => pod.Id == podcastId).FirstOrDefault();

                        // Adicionar episódio
                        Console.WriteLine("Adicionar Episódio:");

                        // Criando instância de episódio com todas as propriedades
                        Console.WriteLine("Digite as informações do episódio: ");
                        Console.Write("Titulo do episódio: ");

                        Episodio episodio = new Episodio();
                        episodio.Titulo = Console.ReadLine();

                        Console.Write("Duração do episódio: ");
                        episodio.Duracao = int.Parse(Console.ReadLine());

                        Console.Write("Ordem do episódio: ");
                        episodio.Ordem = int.Parse(Console.ReadLine());

                        Console.Write("Resumo do episódio: ");
                        episodio.Resumo = Console.ReadLine();


                        Console.Write("Digite o nome do convidado do podcast: ");
                        episodio.Convidados.Add(Console.ReadLine());

                        // Adicionando episódio ao podcast
                        podcastEscolhido.AdicionarEpisodio(episodio);

                        // Exibindo detalhes do podcast e episódio
                        Console.WriteLine(podcastEscolhido.ExibirDetalhes());
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.WriteLine($"Titulo: {episodio.Titulo}");
                        Console.WriteLine($"Duração: {episodio.Duracao} minutos");
                        Console.WriteLine($"Episodio: {episodio.Ordem}");
                        Console.WriteLine($"Resumo: {episodio.Resumo}");
                        Console.WriteLine($"Convidados: {episodio.Convidados.First()}");
                        Console.WriteLine($"Podcast: {episodio.Nome}");
                        Console.WriteLine($"Apresentado por: {podcastEscolhido.Host} da turma de Ds1");


                        Console.WriteLine("Pressione qualquer tecla para sair...");
                        Console.ReadKey();

                        break;

                    case "3":


                        Console.WriteLine("Visualisar todos episódios disponiveis: ");


                        Console.WriteLine("Escolha um Podcast: ");
                        Console.WriteLine();


                        if (!podCaster.ListarTodosPodcasts().Any())
                        {
                            Console.WriteLine("Nenhum podcast cadastrado");

                            break;
                        }


                        foreach (Podcast pod in podCaster.ListarTodosPodcasts())
                        {

                            Console.WriteLine(pod.Id + ": " + pod.Nome + " Apresentado por: " + pod.Host);

                        }

                        int podcastId2 = int.Parse(Console.ReadLine());
                        Console.ReadKey();

                        Console.WriteLine();

                        Podcast podcastEscolhido2 = podCaster.Podcasts.Where(pod => pod.Id == podcastId2).FirstOrDefault();


                        if (!podcastEscolhido2.TodosEpisodios().Any())
                        {
                            Console.WriteLine("Nenhum episodio cadastrado nesse podcast");

                            break;
                        }

                        foreach (Episodio _episodio in podcastEscolhido2.TodosEpisodios())
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Episódio: ");
                            Console.WriteLine($"Titulo: {_episodio.Titulo}");
                            Console.WriteLine($"Duração: {_episodio.Duracao} minutos");
                            Console.WriteLine($"Episodio: {_episodio.Ordem}");
                            Console.WriteLine($"Resumo: {_episodio.Resumo}");
                            Console.WriteLine($"Convidados: {_episodio.Convidados.First()}");
                            Console.WriteLine($"Podcast: {_episodio.Nome}");
                            Console.WriteLine($"Apresentado por: {podcastEscolhido2.Host} da turma de Ds1");

                            Console.WriteLine();
                        }


                        break;

                    case "4":
                        // Sair do programa
                        Console.WriteLine("Saindo do programa...");
                        return; // Isso encerrará o programa

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;

                }
                Console.ReadKey();

            }


        }
    }
}