using E_Trade.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Map
{
    public class OrderUserNoteMap : BaseMap<OrderUserNote>
    {
        public OrderUserNoteMap()
        {
            ToTable("dbo.OrderUserNotes");

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserFirstName).HasMaxLength(255).IsOptional();
            Property(x => x.UserSurName).HasMaxLength(255).IsOptional();
            Property(x => x.UserEmail).HasMaxLength(255).IsRequired();
            Property(x => x.Note).HasMaxLength(65535).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.OrderId).IsRequired();
        }
    }
}
