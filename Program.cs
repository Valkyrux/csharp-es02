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
                Console.WriteLine("Digita il numero del tipo di operazione da effettuare e premi invio\n");

                Console.WriteLine("************************************");
                Console.WriteLine("*  0 - addizione                   *");
                Console.WriteLine("*  1 - sottrazione                 *");
                Console.WriteLine("*  2 - moltiplicazione             *");
                Console.WriteLine("*  3 - divisione                   *");
                Console.WriteLine("*  4 - quadrato                    *");
                Console.WriteLine("*  5 - media                       *");
                Console.WriteLine("*  6 - elevazione a potenza n      *");
                Console.WriteLine("*  7 - trova max e min del vettore *");
                Console.WriteLine("*  9 - exit                        *");
                Console.WriteLine("************************************");

                Console.WriteLine("\n* digita uno dei valori indicati e premi invio:");
                if (int.TryParse(Console.ReadLine(), out iChoose))
                {
                    if (iChoose == 0)
                    {
                        Console.WriteLine("\n*** SOMMA ***\n");
                        Console.WriteLine("Inserisci primo numero");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci secondo numero");
                        int number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nRISULTATO: {0}\n", myMethods.somma(number1, number2));
                    }

                    else if (iChoose == 1)
                    {
                        Console.WriteLine("\n*** SOTTRAZIONE ***\n");
                        Console.WriteLine("Inserisci primo numero");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci secondo numero");
                        int number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nRISULTATO: {0}\n", myMethods.sottrazione(number1, number2));
                    }

                    else if (iChoose == 2)
                    {
                        Console.WriteLine("\n*** MOLTIPLICAZIONE ***\n");
                        Console.WriteLine("Inserisci primo numero");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci secondo numero");
                        int number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nRISULTATO: {0}\n", myMethods.moltiplicazione(number1, number2));
                    }

                    else if (iChoose == 3)
                    {
                        Console.WriteLine("\n*** DIVISIONE ***\n");
                        Console.WriteLine("Inserisci primo numero");
                        float number1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci secondo numero");
                        float number2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("\nRISULTATO: {0}\n", myMethods.divisione(number1, number2));
                    }

                    else if (iChoose == 4)
                    {
                        Console.WriteLine("\n*** QUADRATO ***\n");
                        Console.WriteLine("Inserisci un numero");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nRISULTATO: {0}\n", myMethods.quadrato(number));
                    }

                    else if (iChoose == 5)
                    {
                        Console.WriteLine("\n*** MEDIA DI 10 NUMERI ***\n");
                        float[] arrayNumber = new float[10];
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Inserisci un numero");
                            arrayNumber[i] = float.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("\nRISULTATO: {0}\n", myMethods.media(arrayNumber));
                    }

                    else if (iChoose == 6)
                    {
                        Console.WriteLine("\n*** POTENZA ***\n");
                        Console.WriteLine("Inserisci il numero da elevare a potenza");
                        int value = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci il numero della potenza");
                        int powerValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nRISULTATO: {0}\n", myMethods.potenza(value, powerValue));
                    }

                    else if (iChoose == 7)
                    {
                        Console.WriteLine("Inserisci i valori per il vettore separati da uno spazio");
                        string sNumeri = Console.ReadLine();
                        if(sNumeri == null)
                        {
                            Console.WriteLine("non hai fornito nessun numero");
                            System.Environment.Exit(0);
                        }

                        string[] stringArrayNumeri = sNumeri.Split(' '); 

                        int[] iVect = new int[stringArrayNumeri.Length];

                        for (int i = 0; i < stringArrayNumeri.Length; i++) 
                        {
                            iVect[i] = int.Parse(stringArrayNumeri[i]);
                        };

                        Console.WriteLine("\nRISULTATO: min={0} max={1}\n", myMethods.trovaMinInVettore(iVect), myMethods.trovaMaxInVettore(iVect));
                    }

                    else if (iChoose == 8)
                    {
                        Console.WriteLine("Inserisci i valori per il vettore separati da uno spazio");
                        string sNumeri = Console.ReadLine();
                        if (sNumeri == null)
                        {
                            Console.WriteLine("non hai fornito nessun numero");
                            System.Environment.Exit(0);
                        }

                        string[] stringArrayNumeri = sNumeri.Split(' ');

                        float[] fVect = new float[stringArrayNumeri.Length];

                        for (int i = 0; i < stringArrayNumeri.Length; i++)
                        {
                            fVect[i] = float.Parse(stringArrayNumeri[i]);
                        };

                        Console.WriteLine("\nRISULTATO: mediano = {0}\n", myMethods.trovaMediano(fVect));
                    }

                    else if (iChoose!= 9)
                    {
                        Console.WriteLine("\n*** valore non valido ***\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n*** operazione non valida ***\n");
                }
            }
        }
    }
}
