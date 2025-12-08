using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo15
{
    public struct Transaction
    {
        public decimal montant;
        public bool estUneRentree;
        public string? communication;
        public Temps temps;
    }
}
