﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArabaKirala
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class carrentaldbEntities : DbContext
    {
        public carrentaldbEntities()
            : base("name=carrentaldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Rentals> Rentals { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
    }
}
