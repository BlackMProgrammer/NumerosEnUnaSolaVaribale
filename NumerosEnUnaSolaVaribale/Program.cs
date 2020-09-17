using System;
using System.Collections;

namespace NumerosEnUnaSolaVaribale
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alInt = new ArrayList();
            bool truf;
            do
            {
                Console.WriteLine("Digite el numero que desee agregar.");

                alInt.Add(Console.ReadLine());

                Console.WriteLine("Desea agregar mas numeros? S/N");
                string son = Console.ReadLine().ToLower();

                if (son == "s")
                {
                    truf = true;
                }else{
                    truf = false;
                }
            } while (truf == true);

            foreach (string num in alInt)
            {
                Console.WriteLine(num);
            }
        }
    }
}
