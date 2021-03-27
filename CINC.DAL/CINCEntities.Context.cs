﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CINC.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CAMEntities : DbContext
    {
        public CAMEntities()
            : base("name=CAMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<HarvestTimeTracking> HarvestTimeTrackings { get; set; }
        public DbSet<StorageEdgeBlob> StorageEdgeBlobs { get; set; }
        public DbSet<StorageEdgeEncryptionProvider> StorageEdgeEncryptionProviders { get; set; }
        public DbSet<StorageEdgeStorageProvider> StorageEdgeStorageProviders { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tbAddendum> tbAddendums { get; set; }
        public DbSet<tbAddendumSubType> tbAddendumSubTypes { get; set; }
        public DbSet<tbAssessmentType> tbAssessmentTypes { get; set; }
        public DbSet<tbBillingData> tbBillingDatas { get; set; }
        public DbSet<tbBillingFrequency> tbBillingFrequencies { get; set; }
        public DbSet<tbClientManagementData> tbClientManagementDatas { get; set; }
        public DbSet<tbClientPI> tbClientPIs { get; set; }
        public DbSet<tbClientPM> tbClientPMs { get; set; }
        public DbSet<tbClientPoolFee> tbClientPoolFees { get; set; }
        public DbSet<tbClientRelation> tbClientRelations { get; set; }
        public DbSet<tbClient> tbClients { get; set; }
        public DbSet<tbExpenseBatch> tbExpenseBatches { get; set; }
        public DbSet<tbExpenseItem> tbExpenseItems { get; set; }
        public DbSet<tbMember> tbMembers { get; set; }
        public DbSet<tbMembership> tbMemberships { get; set; }
        public DbSet<tbMembershipLog> tbMembershipLogs { get; set; }
        public DbSet<tbNewManagementCompany> tbNewManagementCompanies { get; set; }
        public DbSet<tbPI> tbPIs { get; set; }
        public DbSet<tbPM> tbPMs { get; set; }
        public DbSet<tbPoolMember> tbPoolMembers { get; set; }
        public DbSet<tbPoolStatu> tbPoolStatus { get; set; }
        public DbSet<tbPreviousManagementCompany> tbPreviousManagementCompanies { get; set; }
        public DbSet<tbRegion> tbRegions { get; set; }
        public DbSet<tbServiceType> tbServiceTypes { get; set; }
        public DbSet<tbState> tbStates { get; set; }
        public DbSet<tbTimeDetail> tbTimeDetails { get; set; }
        public DbSet<Time_Detail> Time_Detail { get; set; }
        public DbSet<pool_passes> pool_passes { get; set; }
        public DbSet<StorageEdgeLocation> StorageEdgeLocations { get; set; }
        public DbSet<tbClientContract> tbClientContracts { get; set; }
        public DbSet<tbClientPool> tbClientPools { get; set; }
        public DbSet<tbPoolPasses_> tbPoolPasses_ { get; set; }
        public DbSet<tbProduct> tbProducts { get; set; }
    }
}