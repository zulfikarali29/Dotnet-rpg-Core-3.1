using AutoMapper;
using Dotnet_rpg_3._1.Dtos.Character;
using Dotnet_rpg_3._1.Dtos.Fight;
using Dotnet_rpg_3._1.Dtos.Skill;
using Dotnet_rpg_3._1.Dtos.Weapon;
using Dotnet_rpg_3._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_rpg_3._1
{
    public class AutoMapperProfile : Profile // Add AutoMapper namespace for Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
                .ForMember(dto => dto.Skills , c=>c.MapFrom(c=>c.CharacterSkills.Select(cs=>cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}
