using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WpfApp2
{
    public partial class XtraReport12 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport12()
        {
            InitializeComponent();
            //Parameters["IdParameter"].Value = 1002;
            IdParameter.Value = "NJ 93300";
        }

    }
}
