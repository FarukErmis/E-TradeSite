using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Entity
{
    public class ShippingRate
    {
        public int Id { get; set; }
        public int VolumetricWeightStart { get; set; }
        public int VolumetricWeightEnd { get; set; }
        [Range(0,1000)]
        public float Rate { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        [ForeignKey("ShippingCompany")]
        public int ShippingCompanyId { get; set; }
        public Region Region { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
    }
}
