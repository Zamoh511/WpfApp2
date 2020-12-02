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

    public partial class Order_BookingReference : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Order_OrderIn fOrderID;
        [Association(@"Order_BookingReferenceReferencesOrder_OrderIn")]
        public Order_OrderIn OrderID
        {
            get { return fOrderID; }
            set { SetPropertyValue<Order_OrderIn>(nameof(OrderID), ref fOrderID, value); }
        }
        DateTime fOrderDate;
        public DateTime OrderDate
        {
            get { return fOrderDate; }
            set { SetPropertyValue<DateTime>(nameof(OrderDate), ref fOrderDate, value); }
        }
        string fBookingRefNo;
        [Indexed(Name = @"iBookingRefNo_Order_BookingReference", Unique = true)]
        [Size(50)]
        public string BookingRefNo
        {
            get { return fBookingRefNo; }
            set { SetPropertyValue<string>(nameof(BookingRefNo), ref fBookingRefNo, value); }
        }
        string fInternalReferenceNo;
        [Size(50)]
        public string InternalReferenceNo
        {
            get { return fInternalReferenceNo; }
            set { SetPropertyValue<string>(nameof(InternalReferenceNo), ref fInternalReferenceNo, value); }
        }
        double fQuantity;
        public double Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<double>(nameof(Quantity), ref fQuantity, value); }
        }
        int fAmtBookedContainers;
        public int AmtBookedContainers
        {
            get { return fAmtBookedContainers; }
            set { SetPropertyValue<int>(nameof(AmtBookedContainers), ref fAmtBookedContainers, value); }
        }
        DateTime fPlannedStartDispatchDate;
        public DateTime PlannedStartDispatchDate
        {
            get { return fPlannedStartDispatchDate; }
            set { SetPropertyValue<DateTime>(nameof(PlannedStartDispatchDate), ref fPlannedStartDispatchDate, value); }
        }
        bool fActive;
        public bool Active
        {
            get { return fActive; }
            set { SetPropertyValue<bool>(nameof(Active), ref fActive, value); }
        }
        int fSiteID;
        public int SiteID
        {
            get { return fSiteID; }
            set { SetPropertyValue<int>(nameof(SiteID), ref fSiteID, value); }
        }
        Library_Sampler fSamplerID;
        [Association(@"Order_BookingReferenceReferencesLibrary_Sampler")]
        public Library_Sampler SamplerID
        {
            get { return fSamplerID; }
            set { SetPropertyValue<Library_Sampler>(nameof(SamplerID), ref fSamplerID, value); }
        }
        string fMonthShipping;
        [Size(50)]
        public string MonthShipping
        {
            get { return fMonthShipping; }
            set { SetPropertyValue<string>(nameof(MonthShipping), ref fMonthShipping, value); }
        }
        string fVesselName;
        [Size(50)]
        public string VesselName
        {
            get { return fVesselName; }
            set { SetPropertyValue<string>(nameof(VesselName), ref fVesselName, value); }
        }
        string fDepot;
        [Size(50)]
        public string Depot
        {
            get { return fDepot; }
            set { SetPropertyValue<string>(nameof(Depot), ref fDepot, value); }
        }
        string fVoyageNo;
        [Size(50)]
        public string VoyageNo
        {
            get { return fVoyageNo; }
            set { SetPropertyValue<string>(nameof(VoyageNo), ref fVoyageNo, value); }
        }
        string fPortOfLoading;
        [Size(50)]
        public string PortOfLoading
        {
            get { return fPortOfLoading; }
            set { SetPropertyValue<string>(nameof(PortOfLoading), ref fPortOfLoading, value); }
        }
        string fPortOfDischarge;
        [Size(50)]
        public string PortOfDischarge
        {
            get { return fPortOfDischarge; }
            set { SetPropertyValue<string>(nameof(PortOfDischarge), ref fPortOfDischarge, value); }
        }
        DateTime fStack1OpenDate;
        public DateTime Stack1OpenDate
        {
            get { return fStack1OpenDate; }
            set { SetPropertyValue<DateTime>(nameof(Stack1OpenDate), ref fStack1OpenDate, value); }
        }
        DateTime fStack1CloseDate;
        public DateTime Stack1CloseDate
        {
            get { return fStack1CloseDate; }
            set { SetPropertyValue<DateTime>(nameof(Stack1CloseDate), ref fStack1CloseDate, value); }
        }
        DateTime fStack2OpenDate;
        public DateTime Stack2OpenDate
        {
            get { return fStack2OpenDate; }
            set { SetPropertyValue<DateTime>(nameof(Stack2OpenDate), ref fStack2OpenDate, value); }
        }
        DateTime fStack2CloseDate;
        public DateTime Stack2CloseDate
        {
            get { return fStack2CloseDate; }
            set { SetPropertyValue<DateTime>(nameof(Stack2CloseDate), ref fStack2CloseDate, value); }
        }
        DateTime fETD_Sailing;
        public DateTime ETD_Sailing
        {
            get { return fETD_Sailing; }
            set { SetPropertyValue<DateTime>(nameof(ETD_Sailing), ref fETD_Sailing, value); }
        }
        DateTime fETA_Arriva;
        public DateTime ETA_Arriva
        {
            get { return fETA_Arriva; }
            set { SetPropertyValue<DateTime>(nameof(ETA_Arriva), ref fETA_Arriva, value); }
        }
        int fContainerSizeID;
        public int ContainerSizeID
        {
            get { return fContainerSizeID; }
            set { SetPropertyValue<int>(nameof(ContainerSizeID), ref fContainerSizeID, value); }
        }
        int fFreeDetentionDays_POD;
        public int FreeDetentionDays_POD
        {
            get { return fFreeDetentionDays_POD; }
            set { SetPropertyValue<int>(nameof(FreeDetentionDays_POD), ref fFreeDetentionDays_POD, value); }
        }
        int fFreeDetention;
        public int FreeDetention
        {
            get { return fFreeDetention; }
            set { SetPropertyValue<int>(nameof(FreeDetention), ref fFreeDetention, value); }
        }
        string fCarrier;
        [Size(50)]
        public string Carrier
        {
            get { return fCarrier; }
            set { SetPropertyValue<string>(nameof(Carrier), ref fCarrier, value); }
        }
        string fCTO_Port;
        [Size(50)]
        public string CTO_Port
        {
            get { return fCTO_Port; }
            set { SetPropertyValue<string>(nameof(CTO_Port), ref fCTO_Port, value); }
        }
        string fBookingAgent;
        [Size(50)]
        public string BookingAgent
        {
            get { return fBookingAgent; }
            set { SetPropertyValue<string>(nameof(BookingAgent), ref fBookingAgent, value); }
        }
        string fClearingAgent;
        [Size(50)]
        public string ClearingAgent
        {
            get { return fClearingAgent; }
            set { SetPropertyValue<string>(nameof(ClearingAgent), ref fClearingAgent, value); }
        }
        int fBookingTypeID;
        public int BookingTypeID
        {
            get { return fBookingTypeID; }
            set { SetPropertyValue<int>(nameof(BookingTypeID), ref fBookingTypeID, value); }
        }
        Library_InspectionCompany fInspectionCompanyID;
        [Association(@"Order_BookingReferenceReferencesLibrary_InspectionCompany")]
        public Library_InspectionCompany InspectionCompanyID
        {
            get { return fInspectionCompanyID; }
            set { SetPropertyValue<Library_InspectionCompany>(nameof(InspectionCompanyID), ref fInspectionCompanyID, value); }
        }
        Library_Terminal fTerminalID;
        [Association(@"Order_BookingReferenceReferencesLibrary_Terminal")]
        public Library_Terminal TerminalID
        {
            get { return fTerminalID; }
            set { SetPropertyValue<Library_Terminal>(nameof(TerminalID), ref fTerminalID, value); }
        }
        bool fNavisUpdated;
        public bool NavisUpdated
        {
            get { return fNavisUpdated; }
            set { SetPropertyValue<bool>(nameof(NavisUpdated), ref fNavisUpdated, value); }
        }
        bool fCartage;
        public bool Cartage
        {
            get { return fCartage; }
            set { SetPropertyValue<bool>(nameof(Cartage), ref fCartage, value); }
        }
        bool fFullWeighed;
        public bool FullWeighed
        {
            get { return fFullWeighed; }
            set { SetPropertyValue<bool>(nameof(FullWeighed), ref fFullWeighed, value); }
        }
        bool fBagMarkSupplied;
        public bool BagMarkSupplied
        {
            get { return fBagMarkSupplied; }
            set { SetPropertyValue<bool>(nameof(BagMarkSupplied), ref fBagMarkSupplied, value); }
        }
        Library_TransportType fTransportTypeID;
        [Association(@"Order_BookingReferenceReferencesLibrary_TransportType")]
        public Library_TransportType TransportTypeID
        {
            get { return fTransportTypeID; }
            set { SetPropertyValue<Library_TransportType>(nameof(TransportTypeID), ref fTransportTypeID, value); }
        }
        int fPackagingTypeID;
        public int PackagingTypeID
        {
            get { return fPackagingTypeID; }
            set { SetPropertyValue<int>(nameof(PackagingTypeID), ref fPackagingTypeID, value); }
        }
        string fEmptyBagsSupplier;
        [Size(50)]
        public string EmptyBagsSupplier
        {
            get { return fEmptyBagsSupplier; }
            set { SetPropertyValue<string>(nameof(EmptyBagsSupplier), ref fEmptyBagsSupplier, value); }
        }
        Library_Packaging fPackagingType;
        [Association(@"Order_BookingReferenceReferencesLibrary_Packaging")]
        public Library_Packaging PackagingType
        {
            get { return fPackagingType; }
            set { SetPropertyValue<Library_Packaging>(nameof(PackagingType), ref fPackagingType, value); }
        }
        bool fUseProductItems;
        public bool UseProductItems
        {
            get { return fUseProductItems; }
            set { SetPropertyValue<bool>(nameof(UseProductItems), ref fUseProductItems, value); }
        }
        string fInvoiceNumber;
        [Size(50)]
        public string InvoiceNumber
        {
            get { return fInvoiceNumber; }
            set { SetPropertyValue<string>(nameof(InvoiceNumber), ref fInvoiceNumber, value); }
        }
        [Association(@"BookingReference_ProductDispatchReferencesOrder_BookingReference")]
        public XPCollection<BookingReference_ProductDispatch> BookingReference_ProductDispatchs { get { return GetCollection<BookingReference_ProductDispatch>(nameof(BookingReference_ProductDispatchs)); } }
        [Association(@"BookingReference_ProductDispatch_LteReferencesOrder_BookingReference")]
        public XPCollection<BookingReference_ProductDispatch_Lte> BookingReference_ProductDispatch_Ltes { get { return GetCollection<BookingReference_ProductDispatch_Lte>(nameof(BookingReference_ProductDispatch_Ltes)); } }
        [Association(@"ContainerReferencesOrder_BookingReference")]
        public XPCollection<Container> Containers { get { return GetCollection<Container>(nameof(Containers)); } }
        [Association(@"Container_BookingTransferReferencesOrder_BookingReference")]
        public XPCollection<Container_BookingTransfer> Container_BookingTransfers { get { return GetCollection<Container_BookingTransfer>(nameof(Container_BookingTransfers)); } }
        [Association(@"Container_BookingTransferReferencesOrder_BookingReference1")]
        public XPCollection<Container_BookingTransfer> Container_BookingTransfers1 { get { return GetCollection<Container_BookingTransfer>(nameof(Container_BookingTransfers1)); } }
        [Association(@"Container_EmptyInReferencesOrder_BookingReference")]
        public XPCollection<Container_EmptyIn> Container_EmptyIns { get { return GetCollection<Container_EmptyIn>(nameof(Container_EmptyIns)); } }
        [Association(@"Container_EmptyOutReferencesOrder_BookingReference")]
        public XPCollection<Container_EmptyOut> Container_EmptyOuts { get { return GetCollection<Container_EmptyOut>(nameof(Container_EmptyOuts)); } }
        [Association(@"Container_FullInReferencesOrder_BookingReference")]
        public XPCollection<Container_FullIn> Container_FullIns { get { return GetCollection<Container_FullIn>(nameof(Container_FullIns)); } }
        [Association(@"Container_FullOutReferencesOrder_BookingReference")]
        public XPCollection<Container_FullOut> Container_FullOuts { get { return GetCollection<Container_FullOut>(nameof(Container_FullOuts)); } }
        [Association(@"Container_PackedReferencesOrder_BookingReference")]
        public XPCollection<Container_Packed> Container_Packeds { get { return GetCollection<Container_Packed>(nameof(Container_Packeds)); } }
        [Association(@"Container_TransferReferencesOrder_BookingReference")]
        public XPCollection<Container_Transfer> Container_Transfers { get { return GetCollection<Container_Transfer>(nameof(Container_Transfers)); } }
        [Association(@"Container_TransferReferencesOrder_BookingReference1")]
        public XPCollection<Container_Transfer> Container_Transfers1 { get { return GetCollection<Container_Transfer>(nameof(Container_Transfers1)); } }
        [Association(@"Document_BookingReferenceReferencesOrder_BookingReference")]
        public XPCollection<Document_BookingReference> Document_BookingReferences { get { return GetCollection<Document_BookingReference>(nameof(Document_BookingReferences)); } }
        [Association(@"ProductItemPickListReferencesOrder_BookingReference")]
        public XPCollection<ProductItemPickList> ProductItemPickLists { get { return GetCollection<ProductItemPickList>(nameof(ProductItemPickLists)); } }
    }

}
