using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class PurchaseOrderItem
    {
        /*[Key, Column(Order = 0)]*/
        public int PurchaseOrderId { get; set; }
        /*[Key, Column(Order = 1)]*/
        public int ItemId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Item Item { get; set; }
    }
}