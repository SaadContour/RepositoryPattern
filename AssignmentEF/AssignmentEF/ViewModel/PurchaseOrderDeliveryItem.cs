using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF.ViewModel 
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

        public DeliveryViewModel Delivery { get; set; }
        public PurchaseOrderViewModel PurchaseOrder { get; set; }
        public ItemViewModel Item { get; set; }
        public ProductViewModel Product { get; set; }
        
    }
}
