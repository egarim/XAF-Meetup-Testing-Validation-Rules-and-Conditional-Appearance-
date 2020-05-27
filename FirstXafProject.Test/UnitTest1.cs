using DevExpress.Data.Linq.Helpers;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using FirstXafProject.Orm;
using NUnit.Framework;

namespace FirstXafProject.Test
{
    public class Tests
    {
        private IObjectSpace objectSpace;
        [SetUp]
        public virtual void SetUp()
        {
            objectSpace = new XPObjectSpaceProvider(new MemoryDataStoreProvider()).CreateObjectSpace();
     
            //XafTypesInfo.Instance.RegisterEntity("Customer", typeof(Customer));
            //XafTypesInfo.Instance.GenerateEntities();
        }

        [Test]
        public void TestBusinessObject()
        {

            var Ds = new DevExpress.Xpo.DB.InMemoryDataStore(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema, true);
            XpoHelper.InitXpo(Ds);

            BoLogic.CreateCustomer("001", "Joche Ojeda");

            BoLogic.CreateInvoice(new System.DateTime(2020, 1, 1), "001");

             var Count= XpoHelper.CreateUnitOfWork().Query<Invoice>().Count();


            Assert.AreEqual(1, Count);
        }
       
        [Test]
        public void TestValidationRule()
        {
            Customer Customer = objectSpace.CreateObject<Customer>();
            RuleSet ruleSet = new RuleSet();
            RuleSetValidationResult result;

            result = ruleSet.ValidateTarget(objectSpace, Customer, DefaultContexts.Save);
            Assert.AreEqual(ValidationState.Invalid,
                result.GetResultItem(CustomerValidationRulesId.CustomerNameIsRequired).State);

            Customer.Name = "Mary Tellitson";
            result = ruleSet.ValidateTarget(objectSpace, Customer, DefaultContexts.Save);
            Assert.AreEqual(ValidationState.Valid,
                result.GetResultItem(CustomerValidationRulesId.CustomerNameIsRequired).State);

          
        }
    }
}