using System;
using Frankenstein.DTO;
using UnityEngine;

namespace CafeBoy.DTO
{
    public interface ICityConfig
    {
        Vector3 SpawnPosition { get; set; }
        Vector3 EndPosition   { get; set; }
    }

    [Serializable]
    public class CityConfig : ICityConfig
    {
        public virtual Vector3 SpawnPosition { get; set; }
        public virtual Vector3 EndPosition   { get; set; }
    }

    public class CityConfigDTO : DTOConfig<CityConfig>, ICityConfig
    {
        public Vector3 _spawnPosition;
        public Vector3 _endPosition;

        public Vector3 SpawnPosition
        {
            get => this._spawnPosition;
            set => this._spawnPosition = value;
        }

        public Vector3 EndPosition
        {
            get => this._endPosition;
            set => this._endPosition = value;
        }

        public override CityConfig ToDTO()
        {
            var result = new CityConfig();
            result.SpawnPosition = this.SpawnPosition;
            result.EndPosition   = this.EndPosition;

            return result;
        }

        [ContextMenu("Setup")]
        public override void Setup()
        {
        }
    }
}