using Cnt.CompositeUI;
using Cnt.CompositeUI.Services;

namespace MyModule
{
    public class MyModuleInit : ModuleInit
    {
        private IWorkItemTypeCatalogService myCatalogService;
        private WorkItem parentWorkItem;

        [ServiceDependency]
        public IWorkItemTypeCatalogService myWorkItemCatalog
        {
            set { myCatalogService = value; }
        }

        [ServiceDependency]
        public WorkItem ParentWorkItem
        {
            set { parentWorkItem = value; }
        }

        public override void Load()
        {
            base.Load();
            //myCatalogService.RegisterWorkItem<MyWorkItem>();
            MyWorkItem myWorkItem = parentWorkItem.WorkItems.AddNew<MyWorkItem>();
            myWorkItem.Run(parentWorkItem.Workspaces["tabWorkspace1"]);
        }
    }
}
