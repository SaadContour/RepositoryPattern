using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class PurchaseOrderDeliveryItem
    {
        /*[Key, Column(Order = 0)]*/
        public int DeliveryId { get; set; }
        /*[Key, Column(Order = 1)]*/
        public int PurchaseOrderId { get; set; }
        /*[Key, Column(Order = 2)]*/
        public int ItemId { get; set; }
        /*[Key, Column(Order = 3)]*/
        public int ProductId { get; set; }

        public Delivery Delivery { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Item Item { get; set; }
        public Product Product { get; set; }
        
    }
}
