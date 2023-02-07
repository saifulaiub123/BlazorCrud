
namespace SOM.Core.DBModel
{
    public class WindowElement : BaseEntity<int>
    {
        public int WindowId { get; set; }
        public int ElementId { get; set; }

        public virtual Window Window { get; set; }
        public virtual Element Element { get; set; }
    }
}
