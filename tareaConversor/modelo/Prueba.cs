using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaConversor.modelo
{
    public class Prueba
    {
        public string nombre {get;set;}
        private string nombre2 { get;set;}

        private int myVar;

        public int MyProperty
        {
            get 
            {   
                return myVar; 
            }
            set 
            { 
                myVar = value; 
            }
        }


        private int _edad;

        public int Edad
        {
            get
            {
                return _edad;
            }
            set 
            { 
                _edad = value; 
            }
        }



        
        



    }
}
