using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Companies
{
    public class Food : Company
    {
        public override int BuyPrice => 250;

        public override int RentaPrice => 250;

        public Food(string name, int index, bool item4) : base(name, index, item4)
        {

        }
    }
}
