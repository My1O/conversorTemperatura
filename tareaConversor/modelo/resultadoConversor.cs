using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaConversor.modelo
{
    internal class resultadoConversor
    {
        public double celsConv { set;  get; }
        public double FarConver { set; get; }
        public double KelvinCon { set; get; }
        //
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public double resultadoCelsiusF(double celsius)
        {  
            double resultado = celsius * 1.8 + (32);
            return resultado;
           
        }
        public  double resultadoFarACels(double far)
        { 
            double resultado = (far - 32) * 5 / 9 + 273.15;
            return resultado;
        }
        public double resultadoCelsiusK(double celsiu)
        {
            double resultado = celsiu + 273.15;
            return resultado;
        }
        public double resultadoKaCels(double Kelvin)
        {
            double resultado = Kelvin - 273.15;
            return resultado;
        }
       
    }
}