
namespace SOM.Core.DBModel
{
    public class Window : BaseEntity<int>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int SubElement { get; set; }
        public bool IsDeleted { get; set; }
    }
}
