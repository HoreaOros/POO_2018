using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ContBancar
{
    public class Cont
    {
        private List<Tranzactie> miscari = new List<Tranzactie>();
        private string titular;
        private decimal sold;
        public Cont(string titular, decimal sold)
        {
            this.titular = titular;
            this.sold = sold;
            Console.WriteLine("Am creat un cont bancar: <titluar> = {0}, <sold> = {1}", titular, sold ); 
        }
        public Cont(string titular): this(titular, 0)
        {
           
        }
        public void Retrage(decimal suma)
        {
            Tranzactie t = new Tranzactie(DateTime.Now, TransactionType.Retragere, suma);
            Console.Write("Incerc sa retrag {0} ... ", suma);
            if (suma <= sold)
            {
                sold -= suma;
                Console.WriteLine("OK");
                miscari.Add(t);
            }
            else
            {
                t.Success = false;
                miscari.Add(t);
                throw new InvalidAmountException("Suma retrasa este prea mare");
            }
                
        }

        public void PrintTranzactii()
        {
            foreach (var item in miscari)
            {
                Console.WriteLine(item);
            }
        }

        public void Depune(decimal suma)
        {
            Tranzactie t = new Tranzactie(DateTime.Now, TransactionType.Depunere, suma);

            Console.WriteLine("Incerc sa depun {0} ... ", suma);
            if (suma > 0)
            {
                sold += suma;
                Console.WriteLine("OK");
                miscari.Add(t);
            }
            else
            {
                t.Success = false;
                miscari.Add(t);
                throw new InvalidAmountException("Suma depusa este negativa");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("Cont: < >");
            Console.WriteLine("\tTitular: {0}", titular);
            Console.WriteLine("\tSold: {0}", sold);
        }
    }
}