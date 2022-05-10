using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dichiaro variabili
            int firstNumber;
            int secondNumber;

            //chiedo il primo numero e gestisco errori
            Console.WriteLine("Inserisci un numero:");
            if (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Questo non è un numero!");
                Environment.Exit(1);
            };

            //chiedo il secondo numero e gestisco errori
            Console.WriteLine("Inserisci un altro numero:");
            if (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Questo non è un numero!");
                Environment.Exit(1);
            };

            //risultato della moltiplicazione dei 2 numeri
            Console.WriteLine("Risultato {0}", Multiplication(firstNumber, secondNumber));
        }

        //creo metodo per la moltiplicazione che poi richiamo in Main
        static int Multiplication(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
