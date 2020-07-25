using System;
using Frankenstein.DTO;
using UnityEngine;

namespace CafeBoy.DTO
{
    public interface IGameConfig
    {
    }

    [Serializable]
    public class GameConfig : IGameConfig
    {
        //public virtual CityCollection          Cities                  { get; set; }
    }

    public class GameConfigDTO : DTOConfig<GameConfig>, IGameConfig
    {
        public override GameConfig ToDTO()
        {
            var result = new GameConfig();

            return result;
        }

        [ContextMenu("Setup")]
        public override void Setup()
        {
        }
    }
}