using CafeBoy.Pool.Entities;
using Frankenstein;

namespace CafeBoy.Pool.Controller
{
    public class GamePoolController : APIController<IGamePoolable>, IGamePoolableService
    {
        
        #region Controller

        protected override void OnEntityCreated(IGamePoolable entity)
        {

        }
        
        #endregion

        
        #region IZombieCrushPool

        IAPIModel IGamePool.CreateCity(params object[] any)
        {
            return this.Owner.CreateCity(any);
        }

        #endregion
    }
}
