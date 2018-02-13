using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroArtistas
{
    class Menu
    {
        public void listarMenu()
        {
            string opcao;
            Console.WriteLine("Seja bem-vindo ao Super RH de Hollywood!!!!");
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("=-==-=-=-==-=-==-=-==-=-==-=-==-=-==-=-==-=-==-=");
            Console.WriteLine("1 – Listar artistas ordenadamente *");
            Console.WriteLine("2 – Cadastrar artista");
            Console.WriteLine("3 – Cadastrar filme");
            Console.WriteLine("4 – Mostrar dados de um filme");
            Console.WriteLine("5 – Sair");
            Console.WriteLine("=-==-=-=-==-=-==-=-==-=-==-=-==-=-==-=-==-=-==-=");

            Console.Write("Digite sua opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    listarArtistas();
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    break;

                default:
                    listarArtistas();
                    break;
            }
        }

        public void listarArtistas()
        {
            listarArtistas listarArt = new listarArtistas();
            listarArt.lista();
        }

    }
}
