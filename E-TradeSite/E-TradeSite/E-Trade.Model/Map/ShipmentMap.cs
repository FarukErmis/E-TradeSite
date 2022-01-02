using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class ShipmentMap : BaseMap<Shipment>
    {
        public ShipmentMap()
        {
            ToTable("dbo.Shipments");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Barcode).HasMaxLength(255).IsOptional();
            Property(x => x.WayBillNo).HasMaxLength(255).IsOptional();
            Property(x => x.InvoiceKey).HasMaxLength(255).IsOptional();
            Property(x => x.CargoOffice).HasMaxLength(255).IsOptional();
            Property(x => x.Code).HasMaxLength(255).IsOptional();
            Property(x => x.DeliveryType).HasMaxLength(255).IsOptional();
            Property(x => x.InvoiceIncluded).IsOptional();
            Property(x => x.PayAtDoorAmount).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.OrderId).IsRequired();
            Property(x => x.BarcodeImage).HasMaxLength(255).IsOptional();
            Property(x => x.TrackingUrl).HasMaxLength(255).IsOptional();
        }
    }
}
