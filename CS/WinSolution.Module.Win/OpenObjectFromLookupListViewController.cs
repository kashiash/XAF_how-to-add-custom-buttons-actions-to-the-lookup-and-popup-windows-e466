using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace WinSolution.Module.Win {
    public partial class OpenObjectFromLookupListViewController : ViewController {
        public OpenObjectFromLookupListViewController() {
            InitializeComponent();
            RegisterActions(components);
            TargetViewType = ViewType.ListView;
            TargetViewNesting = Nesting.Nested;
        }
        private void saOpenObjectFromLookup_Execute(object sender, SimpleActionExecuteEventArgs e) {
            ObjectSpace objectSpaceInternal = Application.CreateObjectSpace();
            e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpaceInternal, objectSpaceInternal.GetObject(e.CurrentObject), true);
            e.ShowViewParameters.TargetWindow = TargetWindow.NewWindow;
            e.ShowViewParameters.Context = TemplateContext.View;
        }
    }
}
