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
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem1 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem2 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem3 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem4 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem5 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem6 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem7 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem8 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem9 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem10 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem11 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            this.saSetActive = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.SaModifySave = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.parametrizedAction1 = new DevExpress.ExpressApp.Actions.ParametrizedAction(this.components);
            this.singleChoiceAction1 = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            this.singleChoiceActionFromCode = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            this.popup = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.popupWindowShowAction1 = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.PostInvoice = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saSetActive
            // 
            this.saSetActive.Caption = "Set Active";
            this.saSetActive.ConfirmationMessage = null;
            this.saSetActive.Id = "InvoiceControllerSaSetActive";
            this.saSetActive.ImageName = "database-icon";
            this.saSetActive.ToolTip = null;
            this.saSetActive.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saSetActive_Execute);
            // 
            // SaModifySave
            // 
            this.SaModifySave.Caption = "Lets Change the caption";
            this.SaModifySave.Category = "Tools";
            this.SaModifySave.ConfirmationMessage = "Are you sure ?";
            this.SaModifySave.Id = "ThisIsMyId";
            this.SaModifySave.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.Caption;
            this.SaModifySave.ToolTip = null;
            this.SaModifySave.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SaModifySave_Execute);
            // 
            // parametrizedAction1
            // 
            this.parametrizedAction1.Caption = "Select Date";
            this.parametrizedAction1.ConfirmationMessage = null;
            this.parametrizedAction1.Id = "parametrizedAction1";
            this.parametrizedAction1.NullValuePrompt = null;
            this.parametrizedAction1.ShortCaption = null;
            this.parametrizedAction1.ToolTip = null;
            this.parametrizedAction1.ValueType = typeof(System.DateTime);
            this.parametrizedAction1.Execute += new DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventHandler(this.parametrizedAction1_Execute);
            // 
            // singleChoiceAction1
            // 
            this.singleChoiceAction1.Caption = "Select your department";
            this.singleChoiceAction1.ConfirmationMessage = null;
            this.singleChoiceAction1.Id = "389bfca2-4b4d-4546-89f5-aee9c5d2a8ff";
            choiceActionItem1.Caption = "Entry 1";
            choiceActionItem1.Id = "Entry 1";
            choiceActionItem1.ImageName = null;
            choiceActionItem2.Caption = "Entry 1";
            choiceActionItem2.Id = "Entry 1";
            choiceActionItem2.ImageName = null;
            choiceActionItem2.Shortcut = null;
            choiceActionItem2.ToolTip = null;
            choiceActionItem3.Caption = "Entry 2";
            choiceActionItem3.Id = "Entry 2";
            choiceActionItem3.ImageName = null;
            choiceActionItem3.Shortcut = null;
            choiceActionItem3.ToolTip = null;
            choiceActionItem4.Caption = "Entry 3";
            choiceActionItem4.Id = "Entry 3";
            choiceActionItem4.ImageName = null;
            choiceActionItem4.Shortcut = null;
            choiceActionItem4.ToolTip = null;
            choiceActionItem5.Caption = "Entry 4";
            choiceActionItem5.Id = "Entry 4";
            choiceActionItem5.ImageName = null;
            choiceActionItem5.Shortcut = null;
            choiceActionItem5.ToolTip = null;
            choiceActionItem6.Caption = "Entry 5";
            choiceActionItem6.Id = "Entry 5";
            choiceActionItem6.ImageName = null;
            choiceActionItem6.Shortcut = null;
            choiceActionItem6.ToolTip = null;
            choiceActionItem1.Items.Add(choiceActionItem2);
            choiceActionItem1.Items.Add(choiceActionItem3);
            choiceActionItem1.Items.Add(choiceActionItem4);
            choiceActionItem1.Items.Add(choiceActionItem5);
            choiceActionItem1.Items.Add(choiceActionItem6);
            choiceActionItem1.Shortcut = null;
            choiceActionItem1.ToolTip = null;
            choiceActionItem7.Caption = "Entry 2";
            choiceActionItem7.Id = "Entry 2";
            choiceActionItem7.ImageName = null;
            choiceActionItem8.Caption = "Entry 1";
            choiceActionItem8.Id = "Entry 1";
            choiceActionItem8.ImageName = null;
            choiceActionItem8.Shortcut = null;
            choiceActionItem8.ToolTip = null;
            choiceActionItem7.Items.Add(choiceActionItem8);
            choiceActionItem7.Shortcut = null;
            choiceActionItem7.ToolTip = null;
            choiceActionItem9.Caption = "Entry 3";
            choiceActionItem9.Id = "Entry 3";
            choiceActionItem9.ImageName = null;
            choiceActionItem10.Caption = "Entry 1";
            choiceActionItem10.Id = "Entry 1";
            choiceActionItem10.ImageName = null;
            choiceActionItem10.Shortcut = null;
            choiceActionItem10.ToolTip = null;
            choiceActionItem11.Caption = "Entry 2";
            choiceActionItem11.Id = "Entry 2";
            choiceActionItem11.ImageName = null;
            choiceActionItem11.Shortcut = null;
            choiceActionItem11.ToolTip = null;
            choiceActionItem9.Items.Add(choiceActionItem10);
            choiceActionItem9.Items.Add(choiceActionItem11);
            choiceActionItem9.Shortcut = null;
            choiceActionItem9.ToolTip = null;
            this.singleChoiceAction1.Items.Add(choiceActionItem1);
            this.singleChoiceAction1.Items.Add(choiceActionItem7);
            this.singleChoiceAction1.Items.Add(choiceActionItem9);
            this.singleChoiceAction1.ToolTip = null;
            this.singleChoiceAction1.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.singleChoiceAction1_Execute);
            // 
            // singleChoiceActionFromCode
            // 
            this.singleChoiceActionFromCode.Caption = "Dynamic Choices";
            this.singleChoiceActionFromCode.ConfirmationMessage = null;
            this.singleChoiceActionFromCode.Id = "f258be60-6c28-4ea3-b892-eb8dd59b5e30";
            this.singleChoiceActionFromCode.ToolTip = null;
            this.singleChoiceActionFromCode.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.singleChoiceActionFromCode_Execute);
            // 
            // popup
            // 
            this.popup.AcceptButtonCaption = null;
            this.popup.CancelButtonCaption = null;
            this.popup.Caption = "Show customer Detail";
            this.popup.ConfirmationMessage = null;
            this.popup.Id = "55b53d66-5681-43fe-bf56-ca983c996a16";
            this.popup.ToolTip = null;
            this.popup.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popup_CustomizePopupWindowParams);
            this.popup.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.popup_Execute);
            // 
            // popupWindowShowAction1
            // 
            this.popupWindowShowAction1.AcceptButtonCaption = null;
            this.popupWindowShowAction1.CancelButtonCaption = null;
            this.popupWindowShowAction1.Caption = "Show List";
            this.popupWindowShowAction1.ConfirmationMessage = null;
            this.popupWindowShowAction1.Id = "ff3999d3-2a6a-4a77-ae27-5a5b39d68647";
            this.popupWindowShowAction1.ToolTip = null;
            this.popupWindowShowAction1.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction1_CustomizePopupWindowParams);
            // 
            // PostInvoice
            // 
            this.PostInvoice.Caption = "Post Invoice";
            this.PostInvoice.ConfirmationMessage = null;
            this.PostInvoice.Id = "00a40cde-6d52-4c61-8364-fe8a92dca626";
            this.PostInvoice.TargetObjectsCriteria = "IsPosted=false";
            this.PostInvoice.TargetObjectsCriteriaMode = DevExpress.ExpressApp.Actions.TargetObjectsCriteriaMode.TrueForAll;
            this.PostInvoice.ToolTip = null;
            this.PostInvoice.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PostInvoice_Execute);
            // 
            // InvoiceController
            // 
            this.Actions.Add(this.saSetActive);
            this.Actions.Add(this.SaModifySave);
            this.Actions.Add(this.parametrizedAction1);
            this.Actions.Add(this.singleChoiceAction1);
            this.Actions.Add(this.singleChoiceActionFromCode);
            this.Actions.Add(this.popup);
            this.Actions.Add(this.popupWindowShowAction1);
            this.Actions.Add(this.PostInvoice);
            this.TargetObjectType = typeof(FirstXafProject.Orm.Invoice);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saSetActive;
        private DevExpress.ExpressApp.Actions.SimpleAction SaModifySave;
        private DevExpress.ExpressApp.Actions.ParametrizedAction parametrizedAction1;
        private DevExpress.ExpressApp.Actions.SingleChoiceAction singleChoiceAction1;
        private DevExpress.ExpressApp.Actions.SingleChoiceAction singleChoiceActionFromCode;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction popup;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowShowAction1;
        private DevExpress.ExpressApp.Actions.SimpleAction PostInvoice;
    }
}
