using System;
using Frankenstein.DTO;
using UnityEngine;

namespace CafeBoyBoot.DTO
{
    public interface ICityConfig
    {
    }

    [Serializable]
    public class CityConfig : ICityConfig
    {
        //public virtual CityCollection          Cities                  { get; set; }
    }

    public class CityConfigDTO : DTOConfig<CityConfig>, ICityConfig
    {
        public override CityConfig ToDTO()
        {
            var result = new CityConfig();

            return result;
        }

        [ContextMenu("Setup")]
        public override void Setup()
        {
        }
    }
}