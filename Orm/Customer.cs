﻿using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.ConditionalAppearance;

namespace FirstXafProject.Orm
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Customer : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Customer(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //HACK Xpo Attributes
        [Indexed(Unique =true)]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }

        string code;
        decimal maxCredit;
        bool active;
        string name;

        [RuleRequiredField(CustomerValidationRulesId.CustomerNameIsRequired, DefaultContexts.Save)]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        public bool Active
        {
            get => active;
            set => SetPropertyValue(nameof(Active), ref active, value);
        }

        [Appearance("DisableMaxCredit", Criteria = "!Active", Enabled = false)]
        public decimal MaxCredit
        {
            get => maxCredit;
            set => SetPropertyValue(nameof(MaxCredit), ref maxCredit, value);
        }


        [Association("Customer-Invoices")]
        public XPCollection<Invoice> Invoices
        {
            get
            {
                return GetCollection<Invoice>(nameof(Invoices));
            }
        }

    }
}