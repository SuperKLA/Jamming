using CafeBoyBoot.DTO.Controller;
using CafeBoyBoot.DTO.Entities;
using Frankenstein;

namespace CafeBoyBoot
{
    public class CafeBoyBoot : IAPIBoot
    {
        public static IAPIBoot Create()
        {
            return new CafeBoyBoot();
        }

        void IAPIBoot.Boot(IoCContainer container)
        {
            #region DTO

            container.Register<IGameDataService>(() => new GameDataController()).AsSingleton();
            // container.Register<IHighlightSpotService>(() => new HighlightSpotController());
            // container.Register<IBuildSystemService>(() => new BuildSystemController());
            // container.Register<IBuildPlacesService>(() => new BuildPlacesController());
            // container.Register<IBuildMenuSelectService>(() => new BuildMenuSelectController());
            // container.Register<IBuildableGhostsService>(() => new BuildableGhostsController());
            // container.Register<IBuildEventsService>(() => new BuildEventsController()).AsSingleton();
            // container.Register<IBuildGridService>(() => new BuildGridController()).AsSingleton();
            // container.Register<IBuildMenuService>(() => new BuildableMenuController()).AsSingleton();
            // container.Register<IBuildableProviderService>(() => new BuildableProviderController()).AsSingleton();

            #endregion
        }
    }
}