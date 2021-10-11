using Opgave_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskOpgave4.Model;

namespace ObligatoriskOpgave4.Managers
{
    public class ManagePlayersDB : IManagePlayers
    {
        private readonly PlayerContext _context;

        public ManagePlayersDB(PlayerContext context)
        {
            _context = context;
        }
        public bool Create(FootballPlayer value)
        {
            
        }

        public FootballPlayer Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FootballPlayer> Get()
        {
            throw new NotImplementedException();
        }

        public FootballPlayer Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, FootballPlayer value)
        {
            throw new NotImplementedException();
        }
    }
}
