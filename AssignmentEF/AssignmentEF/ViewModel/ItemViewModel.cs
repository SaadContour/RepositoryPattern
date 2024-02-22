using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentEF.ViewModel;

public class ItemViewModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Quality { get; set; }
    public int Quantity { get; set; }
    public string Colour { get; set; }
    public decimal Price { get; set; }

    public ICollection<PurchaseOrderItemViewModel> PurchaseOrderItems { get; set; }
    public ICollection<PurchaseOrderDeliveryItem> PurchaseOrderDeliveryItems { get; set; }
}
