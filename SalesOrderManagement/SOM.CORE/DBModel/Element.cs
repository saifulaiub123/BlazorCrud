
namespace SOM.Core.DBModel
{
    public class Element : BaseEntity<int>
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public int ElementTypeId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ElementType ElementType { get; set; }
    }
}
