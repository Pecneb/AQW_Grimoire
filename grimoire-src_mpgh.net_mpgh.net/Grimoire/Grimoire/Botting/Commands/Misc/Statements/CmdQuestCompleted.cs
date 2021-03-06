using System.Threading.Tasks;
using Grimoire.Game;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdQuestCompleted : StatementCommand, IBotCommand
    {
        public CmdQuestCompleted()
        {
            Tag = "Quest";
            Text = "Quest can be turned in";
        }

        public Task Execute(IBotEngine instance)
        {
            if (!Player.Quests.CanComplete(int.Parse(Value1)))
                instance.Index++;
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return $"Quest can be turned in: {Value1}";
        }
    }
}
