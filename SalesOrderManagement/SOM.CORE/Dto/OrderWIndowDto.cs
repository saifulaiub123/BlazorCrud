

namespace SOM.Core.Dto
{
    public class OrderWindowDto
    {
        public int OrderId { get; set; }
        public int WindowId { get; set; }
        public OrderDto Order { get; set; }
        public WindowDto Window { get; set; }
    }
}
