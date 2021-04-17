using System.Collections.Generic;
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Services.CharacterServices
{
    public interface ICharacterServices
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter); 
    }
}