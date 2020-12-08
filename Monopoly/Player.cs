namespace Monopoly
{
    public class Player
    {
        public Player(string name, int cache)
        {
            Name = name;
            Cash = cache;
        }

        public string Name { get; set; }

        public int Cash { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = (Player)obj;

            return Name.Equals(other.Name)
                && Cash.Equals(other.Cash);
        }

        public override int GetHashCode()
        {
            return new { Name, Cash }.GetHashCode();
        }
    }
}
