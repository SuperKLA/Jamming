using Frankenstein;
using Frankenstein.Controls.Entities;

namespace CafeBoy.Pool.Entities
{
    public interface IGamePool
    {
        IAPIModel CreateCity(params object[] any);
    }

    public interface IGamePoolable : IAPIEntity<IGamePoolableService>, IGamePool
    {
    }

    public interface IGamePoolableService : IAPIEntityService, IGamePoolableQuery
    {
    }

    public interface IGamePoolableQuery : IQueryService, IGamePool
    {
    }
}