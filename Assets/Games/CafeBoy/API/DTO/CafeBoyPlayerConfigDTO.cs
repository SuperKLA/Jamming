using System;
using Frankenstein.DTO;
using UnityEngine;

namespace CafeBoy.DTO
{
    public interface ICafeBoyPlayerConfig
    {
    }

    [Serializable]
    public class CafeBoyPlayerConfig : ICafeBoyPlayerConfig
    {
        //public virtual CityCollection          Cities                  { get; set; }
    }

    public class CafeBoyPlayerConfigDTO : DTOConfig<CafeBoyPlayerConfig>, ICafeBoyPlayerConfig
    {
        public override CafeBoyPlayerConfig ToDTO()
        {
            var result = new CafeBoyPlayerConfig();

            return result;
        }

        [ContextMenu("Setup")]
        public override void Setup()
        {
        }
    }
}