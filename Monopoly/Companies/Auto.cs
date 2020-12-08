using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Companies
{
    public class Auto : Company
    {
        public override int BuyPrice => 500;

        public override int RentaPrice => 250;

        public Auto(string name, int index, bool item4) : base(name, index, item4)
        {

        }
    }
}
