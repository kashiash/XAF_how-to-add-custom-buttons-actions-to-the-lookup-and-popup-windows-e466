namespace WinSolution.Module.Win {
    partial class OpenObjectFromPopupListViewController {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.paOpenPopupListView = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // paOpenPopupListView
            // 
            this.paOpenPopupListView.AcceptButtonCaption = null;
            this.paOpenPopupListView.CancelButtonCaption = null;
            this.paOpenPopupListView.Caption = "Open Popup ListView";
            this.paOpenPopupListView.Id = "565142a5-b0f8-4dc5-aa6c-818d81b5002b";
            this.paOpenPopupListView.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction1_CustomizePopupWindowParams);

        }
        #endregion
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction paOpenPopupListView;
    }
}
