using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstXafProject.Orm
{
    public class BoLogic
    {
        public static void CreateInvoice(DateTime InvoiceData,string CustomerCode)
        {
            using (var UoW = XpoHelper.CreateUnitOfWork())
            {
                var CustomerInstance=UoW.FindObject<Customer>(new BinaryOperator(nameof(Customer.Code), CustomerCode));
                Invoice invoice = new Invoice(UoW) {Date=InvoiceData, Customer= CustomerInstance };
                if (UoW.InTransaction)
                    UoW.CommitChanges();
            }

        }

    }
}
