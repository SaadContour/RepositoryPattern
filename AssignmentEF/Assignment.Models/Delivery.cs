using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models;

public class Delivery
{
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public ICollection<PurchaseOrderDeliveryItem> PurchaseOrderDeliveryItem { get; set; }
}