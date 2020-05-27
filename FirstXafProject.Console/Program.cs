using DevExpress.Xpo;
using FirstXafProject.Orm;
using System;
using System.Linq;

namespace FirstXafProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var Ds = new DevExpress.Xpo.DB.InMemoryDataStore(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema, true);
            XpoHelper.InitXpo(Ds);

            BoLogic.CreateCustomer("001", "Joche Ojeda");

            BoLogic.CreateInvoice(new System.DateTime(2020, 1, 1), "001");

            var Count = XpoHelper.CreateUnitOfWork().Query<Invoice>().Count();


          
        }
    }
}
