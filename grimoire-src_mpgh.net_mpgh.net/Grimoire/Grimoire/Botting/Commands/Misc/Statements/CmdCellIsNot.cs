using System;
using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdCellIsNot : StatementCommand, IBotCommand
    {
        public CmdCellIsNot()
        {
            Tag = "Map";
            Text = "Cell is not";
        }

        public Task Execute(IBotEngine instance)
        {
            if (Value1.Equals(Player.Cell, StringComparison.OrdinalIgnoreCase))
                instance.Index++;
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return $"Cell is not: {Value1}";
        }
    }
}
