﻿using CafeBoyBoot.DTO.Entities;
using Frankenstein;

namespace CafeBoyBoot.DTO.Controller
{
    public class GameDataController : APIController<IGameData>, IGameDataService
    {
        private IGameDataService IGameDataService => this;
        
        #region Controller
        
        protected override void OnEntityCreated(IGameData entity)
        {
            
        }

        #endregion


        #region IGameDataService

        GameConfig IGameDataQuery.GameConfig => this.IGameDataService.GameConfig;
        
        GameConfig IGameDataService.GameConfig { get; set; }
        
        #endregion
    }
}