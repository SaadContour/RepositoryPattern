using System;
using System.Collections.Generic;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccessLayer.Data;

public partial class ErpContext : DbContext
{
/*    public ErpContext()
    {
    }
*/
    public ErpContext(DbContextOptions<ErpContext> options) : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<PurchaseOrderDeliveryItem> PurchaseOrderDeliveryItems { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public virtual DbSet<PurchaseOrderItem> PurchaseOrderItem { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PurchaseOrderDeliveryItem>().HasKey(p => new {p.PurchaseOrderId,p.DeliveryId, p.ProductId, p.ItemId });
        modelBuilder.Entity<PurchaseOrderItem>().HasKey(p => new { p.PurchaseOrderId, p.ItemId });
    }
}
