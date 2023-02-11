namespace SOM.Core.Dto
{
    public class WindowDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int? SubElement { get; set; }
        public List<WindowElementDto>? WindowElement { get; set; }
        public List<OrderWindowDto>? OrderWindow { get; set; }
    }
}
