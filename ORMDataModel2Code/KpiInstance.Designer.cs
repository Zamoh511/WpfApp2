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

    public partial class KpiInstance : XPCustomObject
    {
        Guid fOid;
        [Key(true)]
        public Guid Oid
        {
            get { return fOid; }
            set { SetPropertyValue<Guid>(nameof(Oid), ref fOid, value); }
        }
        DateTime fForceMeasurementDateTime;
        public DateTime ForceMeasurementDateTime
        {
            get { return fForceMeasurementDateTime; }
            set { SetPropertyValue<DateTime>(nameof(ForceMeasurementDateTime), ref fForceMeasurementDateTime, value); }
        }
        KpiDefinition fKpiDefinition;
        [Association(@"KpiInstanceReferencesKpiDefinition")]
        public KpiDefinition KpiDefinition
        {
            get { return fKpiDefinition; }
            set { SetPropertyValue<KpiDefinition>(nameof(KpiDefinition), ref fKpiDefinition, value); }
        }
        string fSettings;
        [Size(SizeAttribute.Unlimited)]
        public string Settings
        {
            get { return fSettings; }
            set { SetPropertyValue<string>(nameof(Settings), ref fSettings, value); }
        }
        [Association(@"KpiDefinitionReferencesKpiInstance")]
        public XPCollection<KpiDefinition> KpiDefinitions { get { return GetCollection<KpiDefinition>(nameof(KpiDefinitions)); } }
        [Association(@"KpiHistoryItemReferencesKpiInstance")]
        public XPCollection<KpiHistoryItem> KpiHistoryItems { get { return GetCollection<KpiHistoryItem>(nameof(KpiHistoryItems)); } }
        [Association(@"KpiScorecardScorecards_KpiInstanceIndicatorsReferencesKpiInstance")]
        public XPCollection<KpiScorecardScorecards_KpiInstanceIndicators> KpiScorecardScorecards_KpiInstanceIndicatorss { get { return GetCollection<KpiScorecardScorecards_KpiInstanceIndicators>(nameof(KpiScorecardScorecards_KpiInstanceIndicatorss)); } }
    }

}