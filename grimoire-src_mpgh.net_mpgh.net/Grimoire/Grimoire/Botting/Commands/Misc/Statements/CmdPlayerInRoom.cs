using System;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdPlayerInRoom : StatementCommand, IBotCommand
    {
        public CmdPlayerInRoom()
        {
            Tag = "Player";
            Text = "Player is in room";
        }

        public Task Execute(IBotEngine instance)
        {
            if (World.PlayersInMap.FirstOrDefault(
                    p => p.Equals(Value1, StringComparison.OrdinalIgnoreCase)) == null)
                instance.Index++;
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return $"Player is in room: {Value1}";
        }
    }
}
