using FirstXafProject.Orm;

namespace FirstXafProject.Module.Controllers
{
    partial class InvoiceController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saSetActive = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saSetActive
            // 
            this.saSetActive.Caption = "Set Active";
            this.saSetActive.ConfirmationMessage = null;
            this.saSetActive.Id = "1ad641c8-c943-4807-8464-33d414a4a8b0";
            this.saSetActive.ToolTip = null;
            this.saSetActive.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saSetActive_Execute);
            // 
            // InvoiceController
            // 
            this.Actions.Add(this.saSetActive);
            this.TargetObjectType = typeof(Customer);
            this.TargetViewId = "MyCustomCustomerView";

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saSetActive;
    }
}
