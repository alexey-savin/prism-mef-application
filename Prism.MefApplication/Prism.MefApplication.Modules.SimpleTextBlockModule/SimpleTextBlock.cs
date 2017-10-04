using Prism.Mef.Modularity;
using Prism.MefApplication.Modules.SimpleTextBlockModule.Views;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace Prism.MefApplication.Modules.SimpleTextBlockModule
{
    [ModuleExport(typeof(SimpleTextBlock))]
    public class SimpleTextBlock : IModule
    {
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public SimpleTextBlock(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(HelloPrismView));
        }
    }
}
