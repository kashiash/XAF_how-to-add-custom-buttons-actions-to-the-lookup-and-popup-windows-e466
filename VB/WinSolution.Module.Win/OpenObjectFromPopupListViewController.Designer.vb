Imports Microsoft.VisualBasic
Imports System
Namespace WinSolution.Module.Win
	Partial Public Class OpenObjectFromPopupListViewController
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
			Me.paOpenPopupListView = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
			' 
			' paOpenPopupListView
			' 
			Me.paOpenPopupListView.AcceptButtonCaption = Nothing
			Me.paOpenPopupListView.CancelButtonCaption = Nothing
			Me.paOpenPopupListView.Caption = "Open Popup ListView"
			Me.paOpenPopupListView.Id = "565142a5-b0f8-4dc5-aa6c-818d81b5002b"
'			Me.paOpenPopupListView.CustomizePopupWindowParams += New DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(Me.popupWindowShowAction1_CustomizePopupWindowParams);

		End Sub
		#End Region
		Private WithEvents paOpenPopupListView As DevExpress.ExpressApp.Actions.PopupWindowShowAction
	End Class
End Namespace
