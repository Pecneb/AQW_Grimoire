using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdMonsterNotInRoom : StatementCommand, IBotCommand
    {
        public CmdMonsterNotInRoom()
        {
            Tag = "Monster";
            Text = "Is not in room";
        }

        public Task Execute(IBotEngine instance)
        {
            if (World.IsMonsterAvailable(Value1))
                instance.Index++;
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return $"Monster is not in room: {Value1}";
        }
    }
}
