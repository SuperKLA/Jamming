using CafeBoy.API.DTO;
using CafeBoy.DTO;
using Frankenstein;
using Frankenstein.Controls;
using UnityEngine;

namespace CafeBoy.Game
{
    public class CafeBoySetup : APISetup, IGameDTO
    {
        public Camera EditorCamera;

        private GameConfig _gameConfig;

        public GameConfigDTO GameConfig;

        public int TargetFrameRate = -1;
        

        GameConfig IGameDTO.GameConfig
        {
            get
            {
                if (this._gameConfig == null) this._gameConfig = this.GameConfig.ToDTO();

                return this._gameConfig;
            }
        }

        void Start()
        {
            this.Setup();
            
            if (this.EditorCamera != null) this.EditorCamera.gameObject.SetActive(false);

            if (this.TargetFrameRate > 0)
            {
                Application.targetFrameRate = this.TargetFrameRate;
            }
            
            this.BootEntities();

            new CafeBoyGame().Boot();
        }

        void BootEntities()
        {
            var ioc = this.context.IoC;
            ioc.Register<IGameDTO>(() => this);

            FrankensteinControlsBoot.Create().Boot(ioc);
            CafeBoyBoot.Create().Boot(ioc);
        }
    }
}