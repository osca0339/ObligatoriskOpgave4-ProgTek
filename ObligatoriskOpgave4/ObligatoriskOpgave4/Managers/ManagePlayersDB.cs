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
            try
            {
                _context.Players.Add(value);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public FootballPlayer Delete(int id)
        {
            try
            {
                var playerToDelete = _context.Players.Find(id);
                _context.Players.Remove(playerToDelete);
                _context.SaveChanges();
                return playerToDelete;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<FootballPlayer> Get()
        {
            return _context.Players;
        }

        public FootballPlayer Get(int id)
        {
            return _context.Players.Find(id);
        }

        public bool Update(int id, FootballPlayer value)
        {
            try
            {
                var playerToUpdate = _context.Players.Find(id);
                playerToUpdate.Name = value.Name;
                playerToUpdate.Price = value.Price;
                playerToUpdate.ShirtNumber = value.ShirtNumber;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
