﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstDemo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseFirstDemoEntities : DbContext //DbContext: Classe API para conectar com o banco de dados.
    {
        public DatabaseFirstDemoEntities()
            : base("name=DatabaseFirstDemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        //Entidades geradas automaticamente pelo approach DatabaseFirst
        public virtual DbSet<Post> Post { get; set; }
    }
}
