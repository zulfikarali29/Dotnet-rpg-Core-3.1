using Dotnet_rpg_3._1.Dtos.Character;
using Dotnet_rpg_3._1.Dtos.CharacterSkill;
using Dotnet_rpg_3._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_rpg_3._1.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}
