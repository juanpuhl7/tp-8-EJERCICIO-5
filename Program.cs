/*5) En base al ejercicio anterior, se debe solicitar al usuario que ingrese un día y mes del año,
para luego calcular y mostrar por pantalla la cantidad de días que quedan hasta el fin de año.*/

using System;

namespace EJERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int []diasMeses= {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string []mesesNombre= {"Enero", "Febrero", "Marzo","Abril", "Mayo", "Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            int mes=0, dia=0, cantDias=0;


            Console.WriteLine(" CALCULAR DIAS RESTANTES DEL AÑO ");
            Console.ReadKey(); //espera una tecla

            Console.WriteLine("Ingrese Dia: ");
            dia= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Mes: ");
            mes= Convert.ToInt32(Console.ReadLine());
            Console.Clear(); // limpia consola

            mes=mes-1;
            for(int i=mes; i<12; i++){
                cantDias=cantDias+diasMeses[i];  // suma los meses para saber total dias

            }
            cantDias=cantDias-dia; // resta el dia del total de dias sumados
            Console.WriteLine("FALTAN " + cantDias +" PARA FINALIZAR EL AÑO.");

        }
    }
}
