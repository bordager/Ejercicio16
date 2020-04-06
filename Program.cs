using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero");
            string numero;
            numero = Console.ReadLine();
            if (Esnumero(numero) != true)
            {
                Console.WriteLine("No es un numero");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Numero ingresado: " + numero + " - Tiene " + numero.Length + " digitos" );
            Console.ReadLine();
        }
        public static bool Esnumero(string numero)
        {
            try
            {
                int num = int.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
