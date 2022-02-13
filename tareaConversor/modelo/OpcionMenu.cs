using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaConversor.modelo
{
    public class OpcionMenu
    {
        public int selectedOption { set; get; }
        public bool read()
        {
            Console.WriteLine("Diguite un numero entre 1 -- 5");
            bool output = int.TryParse(Console.ReadLine(), out int eo);
            selectedOption = eo;
            return output;
        }
        
        public void evaluar()
        {
            int seguir;
            do
            {

                if (read())
                {
                    if (selectedOption >= 1 && selectedOption <= 5)
                    {
                        ExecuteMenu(selectedOption);
                    }
                    else
                        Console.WriteLine("Fuera de rango");
                }
                Console.WriteLine("Desea hacer otra conversion ?, escriba 0 para salir");
                seguir = int.Parse(Console.ReadLine());
            } while (seguir != 0);
        }
        public  double pedirDatos()
        { 
            Console.WriteLine("Favor ingresa ingresa el datos a convertir: ");
            double valor = double.Parse(Console.ReadLine());
            return valor;
        }
        public void ExecuteMenu(int opcion)
        {
            resultadoConversor rConversor = new resultadoConversor();                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el valor");
                        Console.WriteLine("El resultado es: " + rConversor.resultadoCelsiusF(pedirDatos()));
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el valor");
                        Console.WriteLine("El resultado es: " + rConversor.resultadoFarACels(pedirDatos()));
                        break;
                    case 3:
                        Console.WriteLine("Ingresa el valor");
                        Console.WriteLine("El resultado es: " + rConversor.resultadoCelsiusK(pedirDatos()));
                        break;
                    case 4:
                        Console.WriteLine("Ingresa el valor");
                        Console.WriteLine("El resultado es: " + rConversor.resultadoKaCels(pedirDatos()));
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            
        }
    }
}
