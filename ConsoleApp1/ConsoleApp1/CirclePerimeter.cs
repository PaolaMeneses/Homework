using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArq
{
    public class CirclePerimeter
    {

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                double resultado;
                Console.WriteLine("Escribir el radio d eun circulo");
                int X = Convert.ToInt16(Console.ReadLine());

                

                    resultado = double.Pi*(X * 2);

                    Console.WriteLine("El Perimetro de un circulo" +" es:" + resultado);
               

                Console.WriteLine("Desear salir?" +
                    "\n 1.Si" +
                    "\n 0.No");

                string respuesta = Console.ReadLine();
                if (respuesta == "1")
                {
                    continuar = false;
                }


            } while (continuar);


        }

    }
}

