﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace WpfApp2.RapidCM_PGS_Dev
{

    public partial class Library_Material
    {
        public Library_Material(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
