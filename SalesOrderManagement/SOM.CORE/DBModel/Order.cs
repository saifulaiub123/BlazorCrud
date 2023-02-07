
namespace SOM.Core.DBModel
{
    public class Order : BaseEntity<int>
    {
        public string Name { get; set; }
        public string State { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<OrderWindow> OrderWindow { get; set; }
    }
}
