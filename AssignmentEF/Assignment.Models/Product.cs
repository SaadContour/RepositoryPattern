using Assignment.Models.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models;
public class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage ="Name is a required field")]
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public string Quality { get; set; }
    public int Quantity { get; set; }
    public string Colour { get; set; }
    public decimal Price { get; set; }
    [AllowedExtension(new string[] {".jpg", ".png", ".jpeg" })]
    [ImageMaxSize(2)]
    public string Image { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public ICollection<PurchaseOrderDeliveryItem> PurchaseOrderDeliveryItems { get; set; }
}