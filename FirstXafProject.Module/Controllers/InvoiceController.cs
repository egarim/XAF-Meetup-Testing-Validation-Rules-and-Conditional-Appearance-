using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using FirstXafProject.Orm;

namespace FirstXafProject.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class InvoiceController : ViewController
    {

 

        public SimpleAction MyAction
        {
            get { return this.saSetActive; }
            private set
            {
                this.saSetActive = value;
            }
        }
        
        public InvoiceController()
        {
            InitializeComponent();
         
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            this.singleChoiceActionFromCode.Items.Add(new ChoiceActionItem("Option 1", this.ObjectSpace.FindObject<Customer>(null)));
            this.singleChoiceActionFromCode.Items.Add(new ChoiceActionItem("Option 2", new DateTime(2020,1,1)));
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            this.singleChoiceActionFromCode.Items.Clear();
        }

        private void saSetActive_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var Instance= e.CurrentObject as Customer;
            Instance.Active = true;
            //BoLogic.CreateInvoice()

            //Instance.Invoices

            //var invoices=this.ObjectSpace.CreateCollection(typeof(Invoice));

            //here is where you should put complex code
        }

        private void SaModifySave_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

            //HACK you can locate actions and controller on this document https://docs.devexpress.com/eXpressAppFramework/113141/concepts/controllers-and-actions/built-in-controllers-and-actions/built-in-controllers-and-actions-in-the-system-module#modificationscontroller
            var modificationController =  this.Frame.GetController<ModificationsController>();
           modificationController.SaveAction.Caption = "Guardar";
        }

        private void parametrizedAction1_Execute(object sender, ParametrizedActionExecuteEventArgs e)
        {
           var StringValue=   e.ParameterCurrentValue as string;
        }

        private void singleChoiceAction1_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {
           var SelectedChoice=  e.SelectedChoiceActionItem;
            var Parent = SelectedChoice.ParentItem;
        }

        private void singleChoiceActionFromCode_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {
            var Data= e.SelectedChoiceActionItem.Data;
        }

        DetailView customerView;
        private void popup_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var CurrentInvoice = this.View.CurrentObject as Invoice;
            var CustomerOs = this.Application.CreateObjectSpace();
            customerView = this.Application.CreateDetailView(CustomerOs, CustomerOs.GetObject(CurrentInvoice.Customer));
            e.View = customerView;
        }

        private void popup_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            var Instance = customerView.CurrentObject as Customer;
            //TODO do whatever i want
        }

        private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {


            e.View = this.Application.CreateListView(typeof(Customer), true);
        }
        void NEwActivated(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PostInvoice_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var CurrentInvoice= this.View.CurrentObject as Invoice;
            CurrentInvoice.IsPosted = true;
            if (this.View.ObjectSpace.IsModified)
                this.View.ObjectSpace.CommitChanges();
        }
    }
}
