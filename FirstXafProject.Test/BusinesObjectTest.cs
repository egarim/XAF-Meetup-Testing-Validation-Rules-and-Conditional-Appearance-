using DevExpress.Data.Linq.Helpers;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using FirstXafProject.Orm;
using NUnit.Framework;

namespace FirstXafProject.Test
{
    public class BusinesObjectTest
    {
       
        [SetUp]
        public virtual void SetUp()
        {
           
     
           
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
       


    }
}