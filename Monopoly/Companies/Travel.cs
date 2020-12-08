using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Companies
{
    public class Travel : Company
    {
        public override int BuyPrice => 700;

        public override int RentaPrice => 300;

        public Travel(string name, int index, bool item4) : base(name, index, item4)
        {

        }
    }
}
