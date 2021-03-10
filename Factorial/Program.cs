/* INICIO PROGRAMA PARA CALCULAR EL FACTORIAL DE UN NÚMERO */

using System; // Usando la libreria 'System'

namespace Factorial
{
    class Program
    {
        static void Main(string[] args) // funcion principal
        {
            Fact();
        }
        
        static void Fact()
        {
            //Variables para calcular los procesos
            
            int number = Convert.ToInt32(Console.ReadLine()); // Número para calcular el factorial (escogido por el usuario)
            int one = 1; // Variable que contiene el valor 1
            int newvar = 1; // Declarar variable newvar (se usará mas tarde)
            
            //Calculando el factorial de un número
            
            while(one <= number) // bucle while que se ejecutara muentras one sea menor que numberPlusOne
            {
                newvar = newvar * one; // Valor de la variable newvar: one(1) * onepp(2) = newvar(2)
                one = one + 1; // Valor de la variable onepp: one(1) + 1 = onepp(2)
                // Console.WriteLine(one);
            }
            Console.WriteLine(newvar); // Escribir el factorial del número elegido
            Fact();
        }
    }   
}

/*FINALIZA PROGRAMA PARA CALCULAR EL FACTORIAL DE UN NÚMERO*/