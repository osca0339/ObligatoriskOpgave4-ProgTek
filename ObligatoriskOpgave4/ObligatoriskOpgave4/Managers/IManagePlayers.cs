using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave_1;

namespace ObligatoriskOpgave4.Managers
{
    interface IManagePlayers
    {
        IEnumerable<FootballPlayer> Get();
        FootballPlayer Get(int id);
        bool Create(FootballPlayer value);
        bool Update(int id, FootballPlayer value);
        FootballPlayer Delete(int id);
    }
}
