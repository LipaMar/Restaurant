﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestauracjaEntities : DbContext
    {
        public RestauracjaEntities()
            : base("name=RestauracjaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Credentials> Credentials { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<Potrawy> Potrawy { get; set; }
        public virtual DbSet<Rezerwacje> Rezerwacje { get; set; }
        public virtual DbSet<Stoliki> Stoliki { get; set; }
    }
}
