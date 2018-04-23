Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.BaseImpl

Namespace WinSolution.Module.Win
	Partial Public Class OpenObjectFromPopupListViewController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			TargetViewNesting = Nesting.Root
			TargetViewType = ViewType.ListView
			TargetObjectType=GetType(DomainObject1)
		End Sub
		Private Sub popupWindowShowAction1_CustomizePopupWindowParams(ByVal sender As Object, ByVal e As CustomizePopupWindowParamsEventArgs) Handles paOpenPopupListView.CustomizePopupWindowParams
			Dim objectSpaceInternal As IObjectSpace = Application.CreateObjectSpace()
			Dim coll As CollectionSourceBase = New CollectionSource(objectSpaceInternal, GetType(Person))
			e.View = Application.CreateListView(Application.FindListViewId(GetType(Person)), coll, False)
		End Sub
	End Class
End Namespace
