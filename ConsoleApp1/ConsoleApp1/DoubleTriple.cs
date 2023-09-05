using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArq

{
    public class DoubleTriple
    {
        public DoubleTriple() { }   

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                double resultado;
                Console.WriteLine("Escribir el primer numero");
                int X = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Escribir el segundo numero");
                int N = Convert.ToInt16(Console.ReadLine());
                if (X > N)
                {

                    resultado = 2 * X;
                        
                        Console.WriteLine(resultado);
                    
                    Console.WriteLine("El doble de"+ X +" es:" + resultado);
                }
                else
                {

                    resultado = (3* N);

                    Console.WriteLine(resultado);
                    Console.WriteLine("El triple de" + N + " es:" + resultado);
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
