using DevExpress.Data.Linq.Helpers;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using FirstXafProject.Orm;
using NUnit.Framework;

namespace FirstXafProject.Test
{
        public class ConditionalAppearanceTest
    {
        private Customer Customer;
        private FakeAppearanceTarget target;
        private AppearanceController controller;
        private DetailView detailView;
       
        [SetUp]
        public virtual void SetUp()
        {
            XPObjectSpaceProvider objectSpaceProvider =
           new XPObjectSpaceProvider(new MemoryDataStoreProvider());
            TestApplication application = new TestApplication();
            ModuleBase testModule = new ModuleBase();
            testModule.AdditionalExportedTypes.Add(typeof(Customer));
            application.Modules.Add(testModule);
            application.Modules.Add(new ConditionalAppearanceModule());
            application.Setup("TestApplication", objectSpaceProvider);
            IObjectSpace objectSpace = objectSpaceProvider.CreateObjectSpace();
            Customer = objectSpace.CreateObject<Customer>();
            target = new FakeAppearanceTarget();
            controller = new AppearanceController();
            detailView = application.CreateDetailView(objectSpace, Customer);
            controller.SetView(detailView);
        }

        [Test]
        public void TestBusinessObject()
        {

            Customer.Active = true;
            controller.RefreshItemAppearance(detailView, "ViewItem", "MaxCredit", target, Customer);
            Assert.IsTrue(target.Enabled);
            Customer.Active = false;
            controller.RefreshItemAppearance(detailView, "ViewItem", "MaxCredit", target, Customer);
            Assert.IsFalse(target.Enabled);
        }
       
  
    }
}