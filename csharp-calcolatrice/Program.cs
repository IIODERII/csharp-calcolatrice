namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nella Calcolatrice!");

            string input = "";
            while (input != "end")
            {
                Console.Write("Scrivere:\n- N+N per l'Addizione;\n- NmenoN per la Sottrazione;\n- N*N per la Moltipicazione;\n- absN per il Valore Assoluto;\n- maxN,N per il Valore Maggiore tra due numeri;\n- minN,N per il Valore Minore tra due numeri;\n- B^E per la Potenza;\n- end per terminare il programma. \n\nInserisci la tua operazione: ");
                input = Console.ReadLine();

                if (input.Contains('+'))
                {
                    int index = input.IndexOf('+');

                    string sub1 = input.Substring(0, index);
                    string sub2 = input.Substring(index + 1);

                    if (input.Contains('.') || input.Contains(','))
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Somma(double.Parse(sub1, System.Globalization.CultureInfo.InvariantCulture), double.Parse(sub2, System.Globalization.CultureInfo.InvariantCulture))}\n");

                    }
                    else
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Somma(int.Parse(sub1), int.Parse(sub2))}\n");
                    }
                }
                else if (input.Contains("meno"))
                {
                    int index = input.IndexOf('m');
                    int indexLast = input.IndexOf('o');

                    string sub1 = input.Substring(0, index);
                    string sub2 = input.Substring(indexLast + 1);

                    if (input.Contains('.') || input.Contains(','))
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Differenza(double.Parse(sub1, System.Globalization.CultureInfo.InvariantCulture), double.Parse(sub2, System.Globalization.CultureInfo.InvariantCulture))}\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Differenza(int.Parse(sub1), int.Parse(sub2))}\n");
                    }
                }
                else if (input.Contains('*'))
                {
                    int index = input.IndexOf('*');

                    string sub1 = input.Substring(0, index);
                    string sub2 = input.Substring(index + 1);

                    if (input.Contains('.') || input.Contains(','))
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Moltiplicazione(double.Parse(sub1, System.Globalization.CultureInfo.InvariantCulture), double.Parse(sub2, System.Globalization.CultureInfo.InvariantCulture))}\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Moltiplicazione(int.Parse(sub1), int.Parse(sub2))}\n");
                    }
                }
                else if (input.Contains('^'))
                {
                    int index = input.IndexOf('^');

                    string sub1 = input.Substring(0, index);
                    string sub2 = input.Substring(index + 1);

                    Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Potenza(int.Parse(sub1), int.Parse(sub2))}\n");
                }
                else if (input.Contains("abs"))
                {
                    int index = input.IndexOf('s');

                    string sub = input.Substring(index + 1);

                    if (input.Contains('.') || input.Contains(','))
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Assoluto(double.Parse(sub, System.Globalization.CultureInfo.InvariantCulture))}\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Assoluto(int.Parse(sub))}\n");
                    }
                }
                else if (input.Contains("max"))
                {
                    int index = input.IndexOf(',');
                    int indexX = input.IndexOf("x");

                    string sub1 = input.Substring(indexX + 1, 1);
                    string sub2 = input.Substring(index + 1);
                    if (sub1 == "-")
                        sub1 = input.Substring(indexX + 2, 1);
                    if (input.Contains('.'))
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Maggiore(double.Parse(sub1, System.Globalization.CultureInfo.InvariantCulture), double.Parse(sub2, System.Globalization.CultureInfo.InvariantCulture))}\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Maggiore(int.Parse(sub1), int.Parse(sub2))}\n");
                    }
                }
                else if (input.Contains("min"))
                {
                    int index = input.IndexOf(',');
                    int indexX = input.IndexOf("n");

                    string sub1 = input.Substring(indexX+1, 1);
                    string sub2 = input.Substring(index + 1);
                    if(sub1 == "-")
                         sub1 = input.Substring(indexX + 2, 1);
                    if (input.Contains('.'))
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Minore(double.Parse(sub1, System.Globalization.CultureInfo.InvariantCulture), double.Parse(sub2, System.Globalization.CultureInfo.InvariantCulture))}\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nIl risultato di {input} è {CalcoliHelper.Minore(int.Parse(sub1), int.Parse(sub2))}\n");
                    }
                }
                else if (input == "end")
                    break;
                else
                {
                    Console.WriteLine("\nValore inserito non valido, riprovare!\n");
                }
            }
        }
    }
}
