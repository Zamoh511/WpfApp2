﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace WpfApp2.RapidCM_PGS_Dev
{

    public partial class Order_VesselHatch
    {
        public Order_VesselHatch(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
