using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Assignment.Models;

public class PurchaseOrder
{
    [Key]
    public int Id { get; set; }
    public string PoNo { get; set; }
    public DateOnly PoIssuedDate { get; set; }

    [Compare(nameof(PoIssuedDate), ErrorMessage = "Expiry Date must be greater than or equal to Issued date")]
    public DateOnly PoExpiryDate { get; set; }
    public bool IsCompleted { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
    public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    public ICollection<PurchaseOrderDeliveryItem> PurchaseOrderDeliveryItems { get; set; }
}