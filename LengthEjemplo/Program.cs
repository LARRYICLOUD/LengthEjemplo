using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthEjemplo
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("HOLA MUNDO SOY UN PROGRAMADOR  EN C# Y EXPERTO EN REDES EXCELENTE");

            //
            //Mostramos cuantos elementos tiene la matriz con la propiedad length
            //Console.WriteLine(numeros.Length );
             double[,] numeros = new double[4, 3] {  { 18, 25, 6 },
                                                    { 19, 28, 1  },
                                                    { 15, 45, 66 },
                                                    { 15, 45, 66 } };

            Console.WriteLine(numeros.Length);


        }
    }




}

