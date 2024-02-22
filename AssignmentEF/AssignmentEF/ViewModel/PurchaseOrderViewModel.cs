using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AssignmentEF.ViewModel;

public class PurchaseOrderViewModel
{
    [Key]
    public int Id { get; set; }
    public string PoNo { get; set; }
    public DateOnly PoIssuedDate { get; set; }
    [Compare(nameof(PoIssuedDate), ErrorMessage = "Expiry date must be greater than the issue date.")]
    public DateOnly PoExpiryDate { get; set; }
    public bool IsCompleted { get; set; }
    public int CompanyId { get; set; }
    public CompanyViewModel Company { get; set; }
    public ICollection<PurchaseOrderItemViewModel> PurchaseOrderItems { get; set; }
    public ICollection<PurchaseOrderDeliveryItem> PurchaseOrderDeliveryItems { get; set; }
}