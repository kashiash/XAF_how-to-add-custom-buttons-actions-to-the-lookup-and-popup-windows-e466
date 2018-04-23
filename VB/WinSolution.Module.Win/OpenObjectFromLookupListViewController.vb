Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions

Namespace WinSolution.Module.Win
	Partial Public Class OpenObjectFromLookupListViewController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			TargetViewType = ViewType.ListView
			TargetViewNesting = Nesting.Nested
		End Sub
		Private Sub saOpenObjectFromLookup_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saOpenObjectFromLookup.Execute
			Dim objectSpaceInternal As ObjectSpace = Application.CreateObjectSpace()
			e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpaceInternal, objectSpaceInternal.GetObject(e.CurrentObject), True)
			e.ShowViewParameters.TargetWindow = TargetWindow.NewWindow
			e.ShowViewParameters.Context = TemplateContext.View
		End Sub
	End Class
End Namespace
