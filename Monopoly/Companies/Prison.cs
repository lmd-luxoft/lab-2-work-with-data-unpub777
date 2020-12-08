using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Companies
{
    public class Prison : Company
    {
        public override int BuyPrice { get => 0; }

        public override int RentaPrice => 1000;

        public override bool CanBuy => false;

        public Prison(string name, int index, bool item4) : base(name, index, item4)
        {

        }
    }
}
