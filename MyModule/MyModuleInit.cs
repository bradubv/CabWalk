using Cnt.CompositeUI;
using Cnt.CompositeUI.Services;

namespace MyModule
{
    public class MyModuleInit : ModuleInit
    {
        private IWorkItemTypeCatalogService myCatalogService;

        [ServiceDependency]
        public IWorkItemTypeCatalogService myWorkItemCatalog
        {
            set { myCatalogService = value; }
        }

        public override void Load()
        {
            base.Load();
            myCatalogService.RegisterWorkItem<MyWorkItem>();
        }
    }
}
