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

    public partial class Library_Weighbridge : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fName;
        [Size(50)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fDescription;
        [Size(300)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        int fSiteID;
        [Indexed(Name = @"iSiteID_Library_Weighbridge")]
        public int SiteID
        {
            get { return fSiteID; }
            set { SetPropertyValue<int>(nameof(SiteID), ref fSiteID, value); }
        }
        string fSerialNo;
        [Size(50)]
        public string SerialNo
        {
            get { return fSerialNo; }
            set { SetPropertyValue<string>(nameof(SerialNo), ref fSerialNo, value); }
        }
        string fVerificationNo;
        [Size(50)]
        public string VerificationNo
        {
            get { return fVerificationNo; }
            set { SetPropertyValue<string>(nameof(VerificationNo), ref fVerificationNo, value); }
        }
        DateTime fDateUpdated;
        public DateTime DateUpdated
        {
            get { return fDateUpdated; }
            set { SetPropertyValue<DateTime>(nameof(DateUpdated), ref fDateUpdated, value); }
        }
        [Association(@"BlockWeighReferencesLibrary_Weighbridge")]
        public XPCollection<BlockWeigh> BlockWeighs { get { return GetCollection<BlockWeigh>(nameof(BlockWeighs)); } }
        [Association(@"BookingReference_ProductDispatchReferencesLibrary_Weighbridge")]
        public XPCollection<BookingReference_ProductDispatch> BookingReference_ProductDispatchs { get { return GetCollection<BookingReference_ProductDispatch>(nameof(BookingReference_ProductDispatchs)); } }
        [Association(@"Container_EmptyInReferencesLibrary_Weighbridge")]
        public XPCollection<Container_EmptyIn> Container_EmptyIns { get { return GetCollection<Container_EmptyIn>(nameof(Container_EmptyIns)); } }
        [Association(@"Container_EmptyOutReferencesLibrary_Weighbridge")]
        public XPCollection<Container_EmptyOut> Container_EmptyOuts { get { return GetCollection<Container_EmptyOut>(nameof(Container_EmptyOuts)); } }
        [Association(@"Container_FullInReferencesLibrary_Weighbridge")]
        public XPCollection<Container_FullIn> Container_FullIns { get { return GetCollection<Container_FullIn>(nameof(Container_FullIns)); } }
        [Association(@"Container_FullOutReferencesLibrary_Weighbridge")]
        public XPCollection<Container_FullOut> Container_FullOuts { get { return GetCollection<Container_FullOut>(nameof(Container_FullOuts)); } }
        [Association(@"Container_PackedReferencesLibrary_Weighbridge")]
        public XPCollection<Container_Packed> Container_Packeds { get { return GetCollection<Container_Packed>(nameof(Container_Packeds)); } }
        [Association(@"Product_ProductDispatchReferencesLibrary_Weighbridge")]
        public XPCollection<Product_ProductDispatch> Product_ProductDispatchs { get { return GetCollection<Product_ProductDispatch>(nameof(Product_ProductDispatchs)); } }
        [Association(@"Product_ProductReceiveReferencesLibrary_Weighbridge")]
        public XPCollection<Product_ProductReceive> Product_ProductReceives { get { return GetCollection<Product_ProductReceive>(nameof(Product_ProductReceives)); } }
        [Association(@"Product_Receive_RailReferencesLibrary_Weighbridge")]
        public XPCollection<Product_Receive_Rail> Product_Receive_Rails { get { return GetCollection<Product_Receive_Rail>(nameof(Product_Receive_Rails)); } }
    }

}
