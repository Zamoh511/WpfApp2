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

    public partial class StockHandling : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fBarcodeScan;
        [Size(SizeAttribute.Unlimited)]
        public string BarcodeScan
        {
            get { return fBarcodeScan; }
            set { SetPropertyValue<string>(nameof(BarcodeScan), ref fBarcodeScan, value); }
        }
        string fLastUser;
        [Size(50)]
        public string LastUser
        {
            get { return fLastUser; }
            set { SetPropertyValue<string>(nameof(LastUser), ref fLastUser, value); }
        }
        DateTime fDateModified;
        public DateTime DateModified
        {
            get { return fDateModified; }
            set { SetPropertyValue<DateTime>(nameof(DateModified), ref fDateModified, value); }
        }
        int fLogCount;
        public int LogCount
        {
            get { return fLogCount; }
            set { SetPropertyValue<int>(nameof(LogCount), ref fLogCount, value); }
        }
    }

}
