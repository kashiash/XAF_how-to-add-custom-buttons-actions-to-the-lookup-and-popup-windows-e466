namespace WinSolution.Module.Win {
    partial class OpenObjectFromLookupListViewController {
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
            this.saOpenObjectFromLookup = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saOpenObjectFromLookup
            // 
            this.saOpenObjectFromLookup.Caption = "Open";
            this.saOpenObjectFromLookup.Category = "PopupActions";
            this.saOpenObjectFromLookup.Id = "0cedb692-9325-4460-b743-d8661a883b21";
            this.saOpenObjectFromLookup.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.saOpenObjectFromLookup.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saOpenObjectFromLookup_Execute);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saOpenObjectFromLookup;
    }
}
