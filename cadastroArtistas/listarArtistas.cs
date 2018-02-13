using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroArtistas
{
    class listarArtistas
    {
        public void lista()
        {
            Artista artista1, artista2, artista3, artista4;

            artista1 = new Artista();
            artista1.codArtista = 1;
            artista1.nome = "Scarlett Johansson";

            artista2 = new Artista();
            artista2.codArtista = 2;
            artista2.nome = "Chris Evans";

            artista3 = new Artista();
            artista3.codArtista = 3;
            artista3.nome = "Will Smith";

            artista4 = new Artista();
            artista4.codArtista = 4;
            artista4.nome = "Mia Khalifa";


            Console.WriteLine(artista4);




        }

    }
}
