using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista. */

            int n, conLis = 1, conN = 0;
            Console.WriteLine("Ingrese un numero ");
            n = int.Parse(Console.ReadLine());

            while(n >= 0){
                while(n != 0){
                    conN++;
                    Console.WriteLine("Ingrese un numero ");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La lista " + conLis + " tiene " + conN + " numeros");
                conLis++;
                conN = 0;
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
