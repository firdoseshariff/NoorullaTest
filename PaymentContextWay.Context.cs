﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositoryPayment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PaymentGateWayEntities : DbContext
    {
        public PaymentGateWayEntities()
            : base("name=PaymentGateWayEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RegisterUser> RegisterUsers { get; set; }
        public virtual DbSet<RoyaltyDepartment> RoyaltyDepartments { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<Vedio> Vedios { get; set; }
    }
}
