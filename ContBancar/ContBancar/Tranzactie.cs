using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContBancar
{
    class Tranzactie
    {
        DateTime data;
        TransactionType tip;
        decimal suma;
        bool success;
        public Tranzactie(DateTime date, TransactionType tip, 
            decimal suma, bool success = true)
        {
            this.data = date;
            this.tip = tip;
            this.suma = suma;
            this.success = success;
        }

        public bool Success {
            get
            {
                return success;
            }
            set
            {
                success = value;
            }
        }
        public override string ToString()
        {
            return data.ToString() + "/" + tip + "/" + suma + "/" + "Success = " + success;
        }
    }

    enum TransactionType
    {
        Retragere,
        Depunere
    }
}
