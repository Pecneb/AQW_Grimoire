using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdLevelLessThan : StatementCommand, IBotCommand
    {
        public CmdLevelLessThan()
        {
            Tag = "This player";
            Text = "Level is less than";
        }

        public Task Execute(IBotEngine instance)
        {
            if (Player.Level >= int.Parse(Value1))
                instance.Index++;
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return $"Level is less than: {Value1}";
        }
    }
}
