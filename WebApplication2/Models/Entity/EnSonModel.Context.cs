﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBKUTUPHANEEntitiesEnSon : DbContext
    {
        public DBKUTUPHANEEntitiesEnSon()
            : base("name=DBKUTUPHANEEntitiesEnSon")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLCEZALAR> TBLCEZALAR { get; set; }
        public virtual DbSet<TBLHAREKET> TBLHAREKET { get; set; }
        public virtual DbSet<TBLKASA> TBLKASA { get; set; }
        public virtual DbSet<TBLKATEGORI> TBLKATEGORI { get; set; }
        public virtual DbSet<TBLKITAP> TBLKITAP { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLUYELER> TBLUYELER { get; set; }
        public virtual DbSet<TBLYAZARR> TBLYAZARR { get; set; }
    }
}
