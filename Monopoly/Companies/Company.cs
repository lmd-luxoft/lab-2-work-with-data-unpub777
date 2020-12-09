namespace Monopoly
{


    public class Company
    {
        public Company(string name, int ownerIndex, int buyPrice, int rentPrice, bool canBuy, bool item4)
        {
            Name = name;
            OwnerIndex = ownerIndex;
            BuyPrice = buyPrice;
            RentaPrice = rentPrice;
            CanBuy = canBuy;
            Item4 = item4;
        }

        public string Name { get; }

        public int OwnerIndex { get; set; }

        public bool Item4 { get; set; }

        public int BuyPrice { get; }

        public int RentaPrice { get; }

        public bool CanBuy { get; }

        public bool CanRent => !CanBuy || HasOwner;

        public bool HasOwner => OwnerIndex != 0;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = (Company)obj;

            return Name.Equals(other.Name)
                && OwnerIndex.Equals(other.OwnerIndex)
                && Item4.Equals(other.Item4)
                && BuyPrice.Equals(other.BuyPrice)
                && RentaPrice.Equals(other.RentaPrice);
        }

        public override int GetHashCode()
        {
            return new { Name, OwnerIndex, BuyPrice, RentaPrice, Item4 }.GetHashCode();
        }
    }
}
