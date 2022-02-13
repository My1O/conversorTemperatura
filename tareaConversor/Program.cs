using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaConversor.modelo;
using tareaConversor.vista;

namespace tareaConversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Show();
            OpcionMenu opcion = new OpcionMenu();
            opcion.evaluar();
            
     
        }
    }
}
