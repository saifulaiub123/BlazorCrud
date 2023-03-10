
namespace SOM.Core.Model
{
    public class OrderModel
    {
        public OrderModel()
        {
            OrderWindow = new List<OrderWindowModel>();
        }
        public int? Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public List<OrderWindowModel>? OrderWindow { get; set; }
    }
}
