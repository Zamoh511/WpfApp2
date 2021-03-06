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

    public partial class Document_Orders : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Order_OrderIn fOrderID;
        [Association(@"Document_OrdersReferencesOrder_OrderIn")]
        public Order_OrderIn OrderID
        {
            get { return fOrderID; }
            set { SetPropertyValue<Order_OrderIn>(nameof(OrderID), ref fOrderID, value); }
        }
        Library_DocumentCategory fDocumentCategoryID;
        [Association(@"Document_OrdersReferencesLibrary_DocumentCategory")]
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
        FileData fFile;
        [Association(@"Document_OrdersReferencesFileData")]
        public FileData File
        {
            get { return fFile; }
            set { SetPropertyValue<FileData>(nameof(File), ref fFile, value); }
        }
    }

}
