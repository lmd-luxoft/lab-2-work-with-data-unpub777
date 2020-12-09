using System;
using System.Collections.Generic;
using System.Linq;

namespace Monopoly
{
    class Monopoly
    {
        public List<Player> _players = new List<Player>();
        public List<Company> _fields = new List<Company>();
        public Monopoly(string[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                _players.Add(new Player(p[i], 6000));
            }

            _fields.Add(new Company("Ford", 0, 500, 250, true, false));
            _fields.Add(new Company("MCDonald", 0, 250, 250, true, false));
            _fields.Add(new Company("Lamoda", 0, 100, 250, true, false));
            _fields.Add(new Company("Air Baltic", 0, 700, 300, true, false));
            _fields.Add(new Company("Nordavia", 0, 700, 300, true, false));
            _fields.Add(new Company("Prison", 0, 0, 1000, false, false));
            _fields.Add(new Company("MCDonald", 0, 250, 250, true, false));
            _fields.Add(new Company("TESLA", 0, 500, 250, true, false));
        }

        internal List<Player> GetPlayersList()
        {
            return _players;
        }

        internal List<Company> GetFieldsList()
        {
            return _fields;
        }

        internal Company GetFieldByName(string name) =>
            _fields.FirstOrDefault(_ => string.Equals(_.Name, name, StringComparison.OrdinalIgnoreCase));

        internal bool Buy(int playerIndex, Company company)
        {
            var x = GetPlayerInfo(playerIndex);

            if (company.CanBuy && !company.HasOwner)
            {
                _players[playerIndex - 1] = new Player(x.Name, x.Cash - company.BuyPrice);
                company.OwnerIndex = playerIndex;

                return true;
            }

            return false;
        }

        internal Player GetPlayerInfo(int index)
        {
            return _players[index - 1];
        }

        internal bool Renta(int playerIndex, Company k)
        {
            var z = GetPlayerInfo(playerIndex);

            if (k.CanRent)
            {
                _players[playerIndex - 1] = new Player(z.Name, z.Cash - k.RentaPrice);

                if (k.HasOwner)
                {
                    var owner = GetPlayerInfo(k.OwnerIndex);
                    if (owner != null)
                    {
                        _players[k.OwnerIndex - 1] = new Player(owner.Name, owner.Cash + k.RentaPrice);
                    }
                }

                return true;
            }

            return false;
        }
    }
}
