using System.Diagnostics.Contracts;
using System.Security;
using System.Security.AccessControl;
using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>

            {
                new Command{Id = 0, HowTo = " egg", Line = " water", Platform = " and pan"},
            new Command{Id = 1, HowTo = "boil  egg", Line = "boil ", Platform = "Kettle and pan"},
            new Command{Id = 2, HowTo = "  egg", Line = " war", Platform = "Kettle  pan"}

        };
            return commands;


        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "boil an egg", Line = "boil water", Platform = "Kettle and pan" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}



// return new Command(Id = 0, HowTo = "boil an egg", Line = "boil water", Platform = "Kettle and pan");

/*
           
            */