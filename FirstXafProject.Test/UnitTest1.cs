using DevExpress.Data.Linq.Helpers;
using DevExpress.Xpo;
using FirstXafProject.Orm;
using NUnit.Framework;

namespace FirstXafProject.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
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