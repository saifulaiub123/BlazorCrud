namespace SOM.Core.Dto
{
    public class OrderDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public List<OrderWindowDto> OrderWindow { get; set; }
    }
}
