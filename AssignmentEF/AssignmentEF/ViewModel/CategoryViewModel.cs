using AssignmentEF.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentEF.ViewModel
{

    public class CategoryViewMOdel
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage =ErrorMessages.RequiredField)]
        [StringLength(100, MinimumLength = 2, ErrorMessage = ErrorMessages.RequiredField)]
        public string Name { get; set; }

        public ICollection<ProductViewModel> Products { get; set; }
    }
}