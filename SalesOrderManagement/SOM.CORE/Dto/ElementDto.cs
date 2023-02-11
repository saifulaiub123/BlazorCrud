namespace SOM.Core.Dto
{
    public class ElementDto
    {
        public int? Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int ElementTypeId { get; set; }

        public ElementTypeDto ElementType { get; set; }
        public List<WindowElementDto>? WindowElement { get; set; }
    }
}
