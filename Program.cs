using System;

namespace punto_temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            float temperaturaPromedio;
            const int DIAS = 7;
            const int SEM = 4;
            int[,] arregloTemp = new int[SEM, DIAS];

            for(int i = 0; i < SEM; i++){
                for( int x = 0; x < DIAS; x++){

                    Console.WriteLine("Ingrese temperatura del Dia {0} de la semana {1}.", x+1,i+1);

                    arregloTemp[i,x] = Convert.ToInt32(Console.ReadLine());
                    acumulador = acumulador + arregloTemp[i,x];

                    Console.Clear();

                }
                Console.WriteLine("\n\n--Termino La semana--\n\n");

            }

            temperaturaPromedio = (float) acumulador / arregloTemp.Length;

            Console.WriteLine("Su temperatura promedio del mes es: {0}",temperaturaPromedio);

            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
