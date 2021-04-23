using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Xpo;
using FirstXafProject.Module;
using FirstXafProject.Module.BusinessObjects;
using FirstXafProject.Module.Controllers;
using FirstXafProject.Orm;
using NUnit.Framework;

namespace FirstXafProject.Test
{
    public class ActionsTest
    {
      
     
        private ViewController controller;
        private DetailView detailView;

        [SetUp]
        public virtual void SetUp()
        {
            XPObjectSpaceProvider objectSpaceProvider =
           new XPObjectSpaceProvider(new MemoryDataStoreProvider());
            TestApplication application = new TestApplication();
           
            var testModule = new FirstXafProjectModule();
            



            application.Modules.Add(testModule);
            //application.Modules.Add(new ConditionalAppearanceModule());



            application.Setup("TestApplication", objectSpaceProvider);
            IObjectSpace objectSpace = objectSpaceProvider.CreateObjectSpace();
            var Customer = objectSpace.CreateObject<XafCustomer>();
           
            controller = new InvoiceController();
            detailView = application.CreateDetailView(objectSpace, Customer);
            controller.SetView(detailView);
        }

        [Test]
        public void TestBusinessObject()
        {
            var CurrentObject = controller.View.CurrentObject;



            //Customer.Active = true;
            //controller.RefreshItemAppearance(detailView, "ViewItem", "MaxCredit", target, Customer);
            //Assert.IsTrue(target.Enabled);
            //Customer.Active = false;
            //controller.RefreshItemAppearance(detailView, "ViewItem", "MaxCredit", target, Customer);
            Assert.IsNotNull(CurrentObject);
        }
    }
}