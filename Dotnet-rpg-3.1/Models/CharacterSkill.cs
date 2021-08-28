using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_rpg_3._1.Models
{
    public class CharacterSkill
    {
        //Composite primary key characterId, skillId
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
