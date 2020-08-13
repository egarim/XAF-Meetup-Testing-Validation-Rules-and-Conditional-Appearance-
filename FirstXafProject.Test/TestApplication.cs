using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Layout;
using System;

namespace FirstXafProject.Test
{
    class TestApplication : XafApplication
    {
        protected override LayoutManager CreateLayoutManagerCore(bool simple)
        {
            return null;
        }
    }
}
