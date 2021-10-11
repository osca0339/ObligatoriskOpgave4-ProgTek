using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskOpgave4.Managers;
using Opgave_1;
using ObligatoriskOpgave4.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObligatoriskOpgave4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        readonly IManagePlayers manager = new ManagePlayers();
        public PlayersController(PlayerContext context)
        {
            manager = new ManagePlayersDB(context);
        }

        // GET: api/<PlayersController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return manager.Get();
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return manager.Get(id);
        }

        // POST api/<PlayersController>
        [HttpPost]
        public bool Post([FromBody] FootballPlayer value)
        {
            return manager.Create(value);
        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] FootballPlayer value)
        {
            return manager.Update(id, value);
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}
