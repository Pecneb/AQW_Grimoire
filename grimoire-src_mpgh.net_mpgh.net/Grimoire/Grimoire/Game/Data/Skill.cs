using Grimoire.Tools;

namespace Grimoire.Game.Data
{
    public class Skill
    {
        public enum SkillType
        {
            Normal,
            Safe
        }

        public string Text { get; set; }
        public SkillType Type { get; set; }
        public string Index { get; set; }
        public int SafeHealth { get; set; }
        public bool SafeMp { get; set; }

        public static string GetSkillName(string index) => Flash.Call<string>("GetSkillName", index);
    }
}
