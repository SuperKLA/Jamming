using System;
using System.Collections.Generic;
using CafeBoy.DTO;
using CafeBoy.DTO.Entities;
using CafeBoy.Pool.Entities;
using Frankenstein;
using Frankenstein.Controls.Entities;

namespace CafeBoy.Game
{
    public class CafeBoyGame : APIModel, IQueryable, IGameData, IGamePoolable
    {
        #region Queries

        // private IZombieCrushPoolableQuery _zombiesPoolQuery;
        //
        // public IZombieCrushPoolableQuery ZombiesPoolQuery
        // {
        //     get
        //     {
        //         if (this._zombiesPoolQuery == null)
        //         {
        //             var svc = this.IQueryable.Service.GetQueryService(ControlsQueryLayer.Pool);
        //             this._zombiesPoolQuery = svc.FindFirstEntity<IZombieCrushPoolableQuery, IZombieCrushPoolable>();
        //         }
        //
        //         return this._zombiesPoolQuery;
        //     }
        // }

        #endregion


        #region Locals

        public GameConfig GameConfig => this.IGameData.Service.GameConfig;

        #endregion


        #region Interface Accessors

        private IQueryable    IQueryable    => this;
        private IGameData     IGameData     => this;
        private IGamePoolable IGamePoolable => this;

        #endregion


        #region APIModel

        public override void Boot(params object[] any)
        {
            this.IGameData.Service     = this.SetupServices<IGameDataService>();
            this.IQueryable.Service    = this.SetupServices<IQueryableService>();
            this.IGamePoolable.Service = this.SetupServices<IGamePoolableService>();
        }

        public override void Destroy()
        {
            base.Destroy();
            this.DestroyServices(this.IQueryable.Service);
        }

        #endregion


        #region IQueryable

        IQueryableService IAPIEntity<IQueryableService>.Service { get; set; }

        List<Guid> IQueryable.Layers => new List<Guid>() {CafeBoyQueryLayer.City};

        bool IQueryable.Matches<TQuery>()
        {
            return typeof(TQuery).IsInstanceOfType(this);
        }

        TService IQueryable.Provide<TService>()
        {
//            if (typeof(TService) == typeof(IPlayerQuery))
//                return (TService) this.IPlayer.Service;
            if (typeof(TService) == typeof(IGamePoolableQuery))
                return (TService) this.IGamePoolable.Service;
            return default(TService);
        }

        #endregion


        #region IGameData

        IGameDataService IAPIEntity<IGameDataService>.Service { get; set; }

        #endregion


        #region IGamePoolable

        IGamePoolableService IAPIEntity<IGamePoolableService>.Service { get; set; }

        IAPIModel IGamePool.CreateCity(params object[] any)
        {
            var c = new City();
            c.Boot(any);
            return c;
        }

        #endregion
    }
}