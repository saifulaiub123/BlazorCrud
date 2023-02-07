using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SOM.Core.Constant;
using SOM.Core.IEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOM.Core.DBModel
{
    public class BaseEntity<TId> : IBaseEntity<TId>, IAuditable
    {
        public BaseEntity()
        {
            DateCreated = DateTime.Now;
            LastUpdated = DateTime.Now;
        }
        public TId Id { get; set; }
        [Column(TypeName = DbDataType.DateTime)]
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = DbDataType.DateTime)]
        public DateTime? LastUpdated { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
