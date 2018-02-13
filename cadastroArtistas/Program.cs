using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroArtistas
{
    class Program
    {
        public int opcaoMenu;

        static void Main(string[] args)
        {
            

            Menu menu = new Menu();
            menu.listarMenu();

            Console.ReadLine();

        }
    }
}
