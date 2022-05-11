using System;

namespace es02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("tabella");
            //int number = 0;

            //for (int i = 0; i < 512; i++)
            //{
            //    if (number == 16)
            //    {
            //        Console.WriteLine();
            //        number = 0;
            //    }
            //    Console.Write("{0} ", Convert.ToChar(i));
            //    number++;

            //

            int iChoose = 8;
            while(iChoose != 9){
                Console.WriteLine("Digita il numero del tipo di operazione da effettuare e premi invio");
                Console.WriteLine("0 - addizione");
                Console.WriteLine("1 - sottrazione");
                Console.WriteLine("2 - moltiplicazione");
                Console.WriteLine("3 - divisione");
                Console.WriteLine("4 - quadrato");
                Console.WriteLine("5 - media");
                Console.WriteLine("6 - elevazione a potenza n");
                Console.WriteLine("9 - exit");

                if (int.TryParse(Console.ReadLine(), out iChoose))
                {
                    if (iChoose == 0)
                    {
                        Console.WriteLine("Somma:");
                        Console.WriteLine("Inserisci primo numero");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci secondo numero");
                        int number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Risultato: {0}", myMethods.somma(number1, number2));
                    }

                    else if (iChoose == 1)
                    {
                        Console.WriteLine("Differenza:");
                        Console.WriteLine("Inserisci primo numero");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci secondo numero");
                        int number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Risultato: {0}", myMethods.sottrazione(number1, number2));
                    }

                    else if (iChoose == 2)
                    {
                        Console.WriteLine("Moltiplicazione:");
                        Console.WriteLine("Inserisci primo numero");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci secondo numero");
                        int number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Risultato: {0}", myMethods.moltiplicazione(number1, number2));
                    }

                    else if (iChoose == 3)
                    {
                        Console.WriteLine("Divisione:");
                        Console.WriteLine("Inserisci primo numero");
                        float number1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci secondo numero");
                        float number2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Risultato: {0}", myMethods.divisione(number1, number2));
                    }

                    else if (iChoose == 4)
                    {
                        Console.WriteLine("Quadrato:");
                        Console.WriteLine("Inserisci un numero");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine("Risultato: {0}", myMethods.quadrato(number));
                    }

                    else if (iChoose == 5)
                    {
                        Console.WriteLine("Media di 10 numeri:");
                        float[] arrayNumber = new float[10];
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Inserisci un numero");
                            arrayNumber[i] = float.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("Risultato: {0}", myMethods.media(arrayNumber));
                    }

                    else if (iChoose == 6)
                    {
                        Console.WriteLine("Potenza:");
                        Console.WriteLine("Inserisci il numero da elevare a potenza");
                        int value = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci il numero della potenza");
                        int powerValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("Risultato: {0}", myMethods.potenza(value, powerValue));
                    }

                    else if (iChoose!= 9)
                    {
                        Console.WriteLine("valore non valido");
                    }
                }
                else
                {
                    Console.WriteLine("operazione non valida");
                }
            }
        }
    }
}
