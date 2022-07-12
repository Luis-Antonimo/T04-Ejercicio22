using System;

namespace T04Ejercicio22
{
    class Program
    {
        static void Main()
        {
            string password = "Nomas2020";
            bool valor = false;
            int x = 0;
            while (valor == false && x < 3)
            {
                Console.WriteLine("Escriba la contraseña (tiene 3 intentos):");
                String escrito = Console.ReadLine();
                valor = Equals(password, escrito);
                x++;
            }
            if (valor)
            {
                Console.WriteLine("Enhorabuena.");
            }
            else
            {
                Console.WriteLine("Ha superado los tres intentos.");
            }
        }
    }
}