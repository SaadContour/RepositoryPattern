using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentEF.ViewModel;

public class DeliveryViewModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DataType(DataType.DateTime, ErrorMessage ="")]
    public DateTime Date { get; set; }
    [Required]
    [RegularExpression(@"^[0-9]+$")]
    public decimal Amount { get; set; }

    public ICollection<PurchaseOrderDeliveryItem> PurchaseOrderDeliveryItem { get; set; }
}