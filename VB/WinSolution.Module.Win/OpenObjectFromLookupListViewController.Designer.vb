Imports Microsoft.VisualBasic
Imports System
Namespace WinSolution.Module.Win
	Partial Public Class OpenObjectFromLookupListViewController
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.saOpenObjectFromLookup = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' saOpenObjectFromLookup
			' 
			Me.saOpenObjectFromLookup.Caption = "Open"
			Me.saOpenObjectFromLookup.Category = "PopupActions"
			Me.saOpenObjectFromLookup.Id = "0cedb692-9325-4460-b743-d8661a883b21"
			Me.saOpenObjectFromLookup.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject
'			Me.saOpenObjectFromLookup.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.saOpenObjectFromLookup_Execute);

		End Sub

		#End Region

		Private WithEvents saOpenObjectFromLookup As DevExpress.ExpressApp.Actions.SimpleAction
	End Class
End Namespace
