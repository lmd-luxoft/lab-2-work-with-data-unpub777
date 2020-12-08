using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Companies
{
    public class Bank : Company
    {
        public override int BuyPrice => 0;

        public override int RentaPrice => 700;

        public override bool CanBuy => false;

        public Bank(string name, int index, bool item4) : base(name, index, item4)
        {

        }
    }
}
