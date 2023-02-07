
namespace SOM.Core.Dto
{
    public class WindowElementDto
    {
        public int WindowId { get; set; }
        public int ElementId { get; set; }

        public WindowDto Window { get; set; }
        public ElementDto Element { get; set; }
    }
}
