using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;

namespace API.Data
{

    // a class used for mocking / testing
    public class MockAPIRepo : IAPIRepo
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Do this first", Line = "Do that 1", Platform = "Somewhere here" },
                new Command { Id = 1, HowTo = "Do this second", Line = "Do that 2", Platform = "Somewhere there" },
                new Command { Id = 2, HowTo = "Do this third", Line = "Do that 3", Platform = "Somewhere here again" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Do this", Line = "Do that", Platform = "Somewhere" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
