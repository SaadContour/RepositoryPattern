using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models;

public class Item
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Quality { get; set; }
    public int Quantity { get; set; }
    public string Colour { get; set; }
    public decimal Price { get; set; }

    public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    public ICollection<PurchaseOrderDeliveryItem> PurchaseOrderDeliveryItems { get; set; }
}
