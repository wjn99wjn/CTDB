﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CTDBEntities : DbContext
    {
        public CTDBEntities()
            : base("name=CTDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbEquipment> tbEquipment { get; set; }
        public virtual DbSet<tbSpecies> tbSpecies { get; set; }
        public virtual DbSet<tbTag> tbTag { get; set; }
        public virtual DbSet<tbUser> tbUser { get; set; }
        public virtual DbSet<tbFile> tbFile { get; set; }
        public virtual DbSet<tbRef> tbRef { get; set; }
        public virtual DbSet<tbLabel> tbLabel { get; set; }
        public virtual DbSet<vQuick> vQuick { get; set; }
        public virtual DbSet<tbScan> tbScan { get; set; }
        public virtual DbSet<tbSlice> tbSlice { get; set; }
        public virtual DbSet<tbSpecimen> tbSpecimen { get; set; }
    }
}
