using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module.Win {
    public partial class OpenObjectFromPopupListViewController : ViewController {
        public OpenObjectFromPopupListViewController() {
            InitializeComponent();
            RegisterActions(components);
            TargetViewNesting = Nesting.Root;
            TargetViewType = ViewType.ListView;
            TargetObjectType=typeof(DomainObject1);
        }
        private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
            IObjectSpace objectSpaceInternal = Application.CreateObjectSpace();
            CollectionSourceBase coll = new CollectionSource(objectSpaceInternal, typeof(Person));
            e.View = Application.CreateListView(
                Application.FindListViewId(typeof(Person)),
                coll,
                false
            );
        }
    }
}
