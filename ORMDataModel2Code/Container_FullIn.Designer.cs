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

    public partial class Container_FullIn : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Container fContainerID;
        [Association(@"Container_FullInReferencesContainer")]
        public Container ContainerID
        {
            get { return fContainerID; }
            set { SetPropertyValue<Container>(nameof(ContainerID), ref fContainerID, value); }
        }
        Order_BookingReference fBookingRefID;
        [Association(@"Container_FullInReferencesOrder_BookingReference")]
        public Order_BookingReference BookingRefID
        {
            get { return fBookingRefID; }
            set { SetPropertyValue<Order_BookingReference>(nameof(BookingRefID), ref fBookingRefID, value); }
        }
        double fContainerGrossWeight;
        public double ContainerGrossWeight
        {
            get { return fContainerGrossWeight; }
            set { SetPropertyValue<double>(nameof(ContainerGrossWeight), ref fContainerGrossWeight, value); }
        }
        DateTime fGrossWeightDate;
        public DateTime GrossWeightDate
        {
            get { return fGrossWeightDate; }
            set { SetPropertyValue<DateTime>(nameof(GrossWeightDate), ref fGrossWeightDate, value); }
        }
        double fContainerNettWeight;
        public double ContainerNettWeight
        {
            get { return fContainerNettWeight; }
            set { SetPropertyValue<double>(nameof(ContainerNettWeight), ref fContainerNettWeight, value); }
        }
        double fContainerTarWeight;
        public double ContainerTarWeight
        {
            get { return fContainerTarWeight; }
            set { SetPropertyValue<double>(nameof(ContainerTarWeight), ref fContainerTarWeight, value); }
        }
        DateTime fTarWeightDate;
        public DateTime TarWeightDate
        {
            get { return fTarWeightDate; }
            set { SetPropertyValue<DateTime>(nameof(TarWeightDate), ref fTarWeightDate, value); }
        }
        DateTime fDateIn;
        public DateTime DateIn
        {
            get { return fDateIn; }
            set { SetPropertyValue<DateTime>(nameof(DateIn), ref fDateIn, value); }
        }
        Library_Transporter fTransporterID;
        [Association(@"Container_FullInReferencesLibrary_Transporter")]
        public Library_Transporter TransporterID
        {
            get { return fTransporterID; }
            set { SetPropertyValue<Library_Transporter>(nameof(TransporterID), ref fTransporterID, value); }
        }
        string fTruckRegistration;
        [Size(50)]
        public string TruckRegistration
        {
            get { return fTruckRegistration; }
            set { SetPropertyValue<string>(nameof(TruckRegistration), ref fTruckRegistration, value); }
        }
        string fTrailer1Registration;
        [Size(50)]
        public string Trailer1Registration
        {
            get { return fTrailer1Registration; }
            set { SetPropertyValue<string>(nameof(Trailer1Registration), ref fTrailer1Registration, value); }
        }
        string fTrailer2Registration;
        [Size(50)]
        public string Trailer2Registration
        {
            get { return fTrailer2Registration; }
            set { SetPropertyValue<string>(nameof(Trailer2Registration), ref fTrailer2Registration, value); }
        }
        string fSamplingSeal;
        [Size(50)]
        public string SamplingSeal
        {
            get { return fSamplingSeal; }
            set { SetPropertyValue<string>(nameof(SamplingSeal), ref fSamplingSeal, value); }
        }
        string fLineSeal;
        [Size(50)]
        public string LineSeal
        {
            get { return fLineSeal; }
            set { SetPropertyValue<string>(nameof(LineSeal), ref fLineSeal, value); }
        }
        string fTransporterDeliveryNote;
        [Size(50)]
        public string TransporterDeliveryNote
        {
            get { return fTransporterDeliveryNote; }
            set { SetPropertyValue<string>(nameof(TransporterDeliveryNote), ref fTransporterDeliveryNote, value); }
        }
        string fCTO;
        [Size(50)]
        public string CTO
        {
            get { return fCTO; }
            set { SetPropertyValue<string>(nameof(CTO), ref fCTO, value); }
        }
        bool fShortShip;
        public bool ShortShip
        {
            get { return fShortShip; }
            set { SetPropertyValue<bool>(nameof(ShortShip), ref fShortShip, value); }
        }
        Library_Site fSiteID;
        [Association(@"Container_FullInReferencesLibrary_Site")]
        public Library_Site SiteID
        {
            get { return fSiteID; }
            set { SetPropertyValue<Library_Site>(nameof(SiteID), ref fSiteID, value); }
        }
        Library_Weighbridge fWeighbridgeID;
        [Association(@"Container_FullInReferencesLibrary_Weighbridge")]
        public Library_Weighbridge WeighbridgeID
        {
            get { return fWeighbridgeID; }
            set { SetPropertyValue<Library_Weighbridge>(nameof(WeighbridgeID), ref fWeighbridgeID, value); }
        }
        string fComments;
        [Size(50)]
        public string Comments
        {
            get { return fComments; }
            set { SetPropertyValue<string>(nameof(Comments), ref fComments, value); }
        }
        int fBookingReferenceID;
        public int BookingReferenceID
        {
            get { return fBookingReferenceID; }
            set { SetPropertyValue<int>(nameof(BookingReferenceID), ref fBookingReferenceID, value); }
        }
        int feFlag;
        public int eFlag
        {
            get { return feFlag; }
            set { SetPropertyValue<int>(nameof(eFlag), ref feFlag, value); }
        }
        string fLastUser;
        [Size(50)]
        public string LastUser
        {
            get { return fLastUser; }
            set { SetPropertyValue<string>(nameof(LastUser), ref fLastUser, value); }
        }
    }

}
