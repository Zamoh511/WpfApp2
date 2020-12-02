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

    public partial class WagonConsignment : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fConsignmentNo;
        [Size(50)]
        public string ConsignmentNo
        {
            get { return fConsignmentNo; }
            set { SetPropertyValue<string>(nameof(ConsignmentNo), ref fConsignmentNo, value); }
        }
        string fRailAccountNo;
        [Size(50)]
        public string RailAccountNo
        {
            get { return fRailAccountNo; }
            set { SetPropertyValue<string>(nameof(RailAccountNo), ref fRailAccountNo, value); }
        }
        Library_Siding fDestinationSidingID;
        [Association(@"WagonConsignmentReferencesLibrary_Siding")]
        public Library_Siding DestinationSidingID
        {
            get { return fDestinationSidingID; }
            set { SetPropertyValue<Library_Siding>(nameof(DestinationSidingID), ref fDestinationSidingID, value); }
        }
        DateTime fLoadDate;
        public DateTime LoadDate
        {
            get { return fLoadDate; }
            set { SetPropertyValue<DateTime>(nameof(LoadDate), ref fLoadDate, value); }
        }
        Order_OrderIn fOrderID;
        [Association(@"WagonConsignmentReferencesOrder_OrderIn")]
        public Order_OrderIn OrderID
        {
            get { return fOrderID; }
            set { SetPropertyValue<Order_OrderIn>(nameof(OrderID), ref fOrderID, value); }
        }
        string fTrainNo;
        [Size(50)]
        public string TrainNo
        {
            get { return fTrainNo; }
            set { SetPropertyValue<string>(nameof(TrainNo), ref fTrainNo, value); }
        }
        int fMessageID;
        public int MessageID
        {
            get { return fMessageID; }
            set { SetPropertyValue<int>(nameof(MessageID), ref fMessageID, value); }
        }
        int fTotalMass;
        public int TotalMass
        {
            get { return fTotalMass; }
            set { SetPropertyValue<int>(nameof(TotalMass), ref fTotalMass, value); }
        }
        int fWagonCount;
        public int WagonCount
        {
            get { return fWagonCount; }
            set { SetPropertyValue<int>(nameof(WagonCount), ref fWagonCount, value); }
        }
        double fLocoMass;
        public double LocoMass
        {
            get { return fLocoMass; }
            set { SetPropertyValue<double>(nameof(LocoMass), ref fLocoMass, value); }
        }
        double fWagonMass;
        public double WagonMass
        {
            get { return fWagonMass; }
            set { SetPropertyValue<double>(nameof(WagonMass), ref fWagonMass, value); }
        }
        string fDirection;
        [Size(50)]
        public string Direction
        {
            get { return fDirection; }
            set { SetPropertyValue<string>(nameof(Direction), ref fDirection, value); }
        }
        string fSenderSidingNumber;
        [Size(50)]
        public string SenderSidingNumber
        {
            get { return fSenderSidingNumber; }
            set { SetPropertyValue<string>(nameof(SenderSidingNumber), ref fSenderSidingNumber, value); }
        }
        string fCommodityCode;
        [Size(50)]
        public string CommodityCode
        {
            get { return fCommodityCode; }
            set { SetPropertyValue<string>(nameof(CommodityCode), ref fCommodityCode, value); }
        }
        [Association(@"Product_Dispatch_RailReferencesWagonConsignment")]
        public XPCollection<Product_Dispatch_Rail> Product_Dispatch_Rails { get { return GetCollection<Product_Dispatch_Rail>(nameof(Product_Dispatch_Rails)); } }
        [Association(@"Product_Receive_RailReferencesWagonConsignment")]
        public XPCollection<Product_Receive_Rail> Product_Receive_Rails { get { return GetCollection<Product_Receive_Rail>(nameof(Product_Receive_Rails)); } }
    }

}