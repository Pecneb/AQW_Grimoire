using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdManaGreaterThan : StatementCommand, IBotCommand
    {
        public CmdManaGreaterThan()
        {
            Tag = "This player";
            Text = "Mana is greater than";
        }

        public Task Execute(IBotEngine instance)
        {
            if (Player.Mana <= int.Parse(Value1))
                instance.Index++;
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return $"Mana is greater than: {Value1}";
        }
    }
}
