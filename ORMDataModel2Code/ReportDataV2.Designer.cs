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

    public partial class ReportDataV2 : XPCustomObject
    {
        Guid fOid;
        [Key(true)]
        public Guid Oid
        {
            get { return fOid; }
            set { SetPropertyValue<Guid>(nameof(Oid), ref fOid, value); }
        }
        string fObjectTypeName;
        [Size(512)]
        public string ObjectTypeName
        {
            get { return fObjectTypeName; }
            set { SetPropertyValue<string>(nameof(ObjectTypeName), ref fObjectTypeName, value); }
        }
        byte[] fContent;
        [Size(SizeAttribute.Unlimited)]
        [MemberDesignTimeVisibility(true)]
        public byte[] Content
        {
            get { return fContent; }
            set { SetPropertyValue<byte[]>(nameof(Content), ref fContent, value); }
        }
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fParametersObjectTypeName;
        [Size(512)]
        public string ParametersObjectTypeName
        {
            get { return fParametersObjectTypeName; }
            set { SetPropertyValue<string>(nameof(ParametersObjectTypeName), ref fParametersObjectTypeName, value); }
        }
        bool fIsInplaceReport;
        public bool IsInplaceReport
        {
            get { return fIsInplaceReport; }
            set { SetPropertyValue<bool>(nameof(IsInplaceReport), ref fIsInplaceReport, value); }
        }
        string fPredefinedReportType;
        [Size(512)]
        public string PredefinedReportType
        {
            get { return fPredefinedReportType; }
            set { SetPropertyValue<string>(nameof(PredefinedReportType), ref fPredefinedReportType, value); }
        }
    }

}
