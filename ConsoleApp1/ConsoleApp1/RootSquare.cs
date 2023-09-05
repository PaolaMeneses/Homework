using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArq
{
    public class RootSquare
    {
        public RootSquare() { }

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                double resultado;
                Console.WriteLine("Escribir un numero");
                int X = Convert.ToInt16(Console.ReadLine());
                
                if (X < 0)
                {

                    resultado = X * X;

                    Console.WriteLine(resultado);

                    Console.WriteLine("El cuadrado de" + X + " es:" + resultado);
                }
                else
                {

                    resultado = (Math.Sqrt(X));

                    Console.WriteLine(resultado);
                    Console.WriteLine("La raiz cuadrada de" + X + " es:" + resultado);
                }

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
