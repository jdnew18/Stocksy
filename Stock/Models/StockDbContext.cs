﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Stocksy.Stock.Models;

public partial class StockDbContext : DbContext
{
    public static readonly string connectionString = "DataSource=./Database/StockDatabase.db";

    public StockDbContext()
    {
    }

    public StockDbContext(DbContextOptions<StockDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Quote> Quote { get; set; }

    public virtual DbSet<Stock> Stock { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite(connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Quote>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Stock).WithMany(p => p.Quote).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
