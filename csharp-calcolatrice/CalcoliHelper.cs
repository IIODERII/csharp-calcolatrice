using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int Somma (int n1,  int n2) => n1+n2;
        public static double Somma (double n1, double n2) => n1+n2;

        public static int Differenza (int n1, int n2) => n1-n2;
        public static double Differenza(double n1, double n2) => n1 - n2;

        public static int Moltiplicazione (int n1, int n2) => n1*n2;
        public static double Moltiplicazione(double n1, double n2) => n1 * n2;

        public static int Assoluto(int n)
        {
            if(n < 0)
            {
                return n - (2 * n); 
            }
            return n;
        }
        public static double Assoluto(double n)
        {
            if (n < 0)
            {
                return n - (2 * n);
            }
            return n;
        }

        public static int Minore (int n1, int n2) => (n1 < n2) ? n1 : n2;
        public static double Minore(double n1, double n2) => (n1 < n2) ? n1 : n2;

        public static int Maggiore(int n1, int n2) => (n1 > n2) ? n1 : n2;
        public static double Maggiore(double n1, double n2) => (n1 > n2) ? n1 : n2;

        //Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi si chiama POLIMORFISMO

        //BONUS

        public static double Potenza(int baseN, int esponente)
        {
            if (esponente == 0)
                return 1;

            
            int tot = 1;
            for (int i = 0; i < CalcoliHelper.Assoluto(esponente); i++)
            {
                tot*= baseN;
            }
            if (esponente < 0)
                return (double)1/tot;

            return tot;

        }
    }
}
