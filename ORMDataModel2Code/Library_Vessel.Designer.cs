﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace WpfApp2.RapidCM_PGS_Dev
{

    public partial class Library_Vessel : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fVesselName;
        [Size(255)]
        public string VesselName
        {
            get { return fVesselName; }
            set { SetPropertyValue<string>(nameof(VesselName), ref fVesselName, value); }
        }
        string fShippingLine;
        [Size(255)]
        public string ShippingLine
        {
            get { return fShippingLine; }
            set { SetPropertyValue<string>(nameof(ShippingLine), ref fShippingLine, value); }
        }
        [Association(@"Order_VesselIntakeReferencesLibrary_Vessel")]
        public XPCollection<Order_VesselIntake> Order_VesselIntakes { get { return GetCollection<Order_VesselIntake>(nameof(Order_VesselIntakes)); } }
    }

}
