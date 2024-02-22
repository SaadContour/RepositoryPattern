using Assignment.Models;
using AssignmentEF.Utility;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace AssignmentEF.ViewModel
{
    public class ProductViewModel
    {
        [Required (ErrorMessage = ErrorMessages.RequiredField)]
        public int ProductId { get; set; }
        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public string Name { get; set; }
        /*[Required(ErrorMessage = ErrorMessages.RequiredField)]*/
        public int CategoryId { get; set; }
        [Required (ErrorMessage = ErrorMessages.RequiredField)]
        public string Quality { get; set; }
        [Required (ErrorMessage = ErrorMessages.RequiredField)]
        public int Quantity { get; set; }
        [Required (ErrorMessage = ErrorMessages.RequiredField)]
        public string Colour { get; set; }
        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public decimal Price { get; set; }
    /*        [AllowedExtension(new string[] { ".jpg", ".png", ".jpeg" })]*/
        //[FileExtensions(Extensions = "jpg, JPG,jpeg,png", ErrorMessage = ErrorMessages.FileType)]
        [ImageMaxSize(2, ErrorMessage = ErrorMessages.FileSize)]
        public IFormFile Image { get; set; }
        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public string Description { get; set; }
        [AllowNull]
        public Category? Category { get;}
        [AllowNull]
        public ICollection<PurchaseOrderDeliveryItem>? PurchaseOrderDeliveryItems { get; set; }
    }
}
