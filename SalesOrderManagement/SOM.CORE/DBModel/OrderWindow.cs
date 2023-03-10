namespace SOM.Core.DBModel
{
    public class OrderWindow : BaseEntity<int>
    {
        public int OrderId { get; set; }
        public int WindowId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Order Order { get; set; }
        public virtual Window Window { get; set; }

    }
}
