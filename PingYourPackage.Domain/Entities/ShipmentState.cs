using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain.Entities
{
    

    public class ShipmentState : IEntity
    {
        public enum ShipmentStatus
        {

            Ordered = 1,
            Scheduled = 2,
            InTransit = 3,
            Delivered = 4
        }

        [Key]
        public Guid Key { get; set; }
        public Guid ShipmentKey { get; set; }

        [Required]
        public ShipmentStatus Shipment_Status { get; set; }
        public DateTime CreatedOn { get; set; }

        public Shipment Shipment { get; set; }
    }
}
