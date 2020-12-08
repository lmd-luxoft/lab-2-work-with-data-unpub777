namespace Monopoly
{


    public abstract class Company
    {
        public Company(string name, int ownerIndex, bool item4)
        {
            Name = name;
            OwnerIndex = ownerIndex;
            Item4 = item4;
        }

        public string Name { get; }

        public int OwnerIndex { get; set; }

        public bool Item4 { get; set; }

        public abstract int BuyPrice { get; }

        public abstract int RentaPrice { get; }

        public virtual bool CanBuy { get => OwnerIndex == 0; }

        public bool CanRent => CanBuy || OwnerIndex != 0;

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
