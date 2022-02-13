using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaConversor.vista
{
    internal class Menu
    {
        public void Show() 
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Convertir C a F");
            Console.WriteLine("2. Convertir F a C");
            Console.WriteLine("3. Convertir C a K");
            Console.WriteLine("4. Convertir K a C");
            Console.WriteLine("5. Salir");
            Console.WriteLine("********************");
            Console.WriteLine("Ingrese una opcion valida");
        }

    }
}
