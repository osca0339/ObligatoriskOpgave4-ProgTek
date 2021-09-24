using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave_1;

namespace ObligatoriskOpgave4.Managers
{
    public class ManagePlayers: IManagePlayers
    {
        private static List<FootballPlayer> footballPlayers = new List<FootballPlayer>()
        {
            new FootballPlayer(1, "Johan", 100, 1),
            new FootballPlayer(2, "Skipper", 200, 2),
            new FootballPlayer(3, "Pileflet", 300, 3)
        };



        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(footballPlayers);
        }

        public FootballPlayer Get(int id)
        {
            return footballPlayers.Find(f => f.Id == id);
        }

        public bool Create(FootballPlayer value)
        {
            footballPlayers.Add(value);
            return true;
        }

        public bool Update(int id, FootballPlayer value)
        {
            FootballPlayer footballPlayer = Get(id);
            if (footballPlayer != null)
            {
                footballPlayer.Id = value.Id;
                footballPlayer.Name = value.Name;
                footballPlayer.Price = value.Price;
                footballPlayer.ShirtNumber = value.ShirtNumber;

                return true;
            }

            return false;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer footballPlayer = Get(id);
            footballPlayers.Remove(footballPlayer);
            return footballPlayer;
        }
    }
}
