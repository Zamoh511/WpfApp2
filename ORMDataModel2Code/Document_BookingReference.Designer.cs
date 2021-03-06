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

    public partial class Document_BookingReference : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Order_BookingReference fBookingID;
        [Association(@"Document_BookingReferenceReferencesOrder_BookingReference")]
        public Order_BookingReference BookingID
        {
            get { return fBookingID; }
            set { SetPropertyValue<Order_BookingReference>(nameof(BookingID), ref fBookingID, value); }
        }
        Library_DocumentCategory fDocumentCategoryID;
        [Association(@"Document_BookingReferenceReferencesLibrary_DocumentCategory")]
        public Library_DocumentCategory DocumentCategoryID
        {
            get { return fDocumentCategoryID; }
            set { SetPropertyValue<Library_DocumentCategory>(nameof(DocumentCategoryID), ref fDocumentCategoryID, value); }
        }
        string fDocumentName;
        [Size(50)]
        public string DocumentName
        {
            get { return fDocumentName; }
            set { SetPropertyValue<string>(nameof(DocumentName), ref fDocumentName, value); }
        }
        DateTime fUploadDate;
        public DateTime UploadDate
        {
            get { return fUploadDate; }
            set { SetPropertyValue<DateTime>(nameof(UploadDate), ref fUploadDate, value); }
        }
        Guid fFile;
        [Indexed(Name = @"iFile_Document_BookingReference")]
        public Guid File
        {
            get { return fFile; }
            set { SetPropertyValue<Guid>(nameof(File), ref fFile, value); }
        }
    }

}
