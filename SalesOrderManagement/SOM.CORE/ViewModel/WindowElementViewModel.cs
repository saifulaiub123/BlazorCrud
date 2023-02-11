

namespace SOM.Core.ViewModel
{
    public class WindowElementViewModel
    {
        public int? Id { get; set; }
        public int WindowId { get; set; }
        public string WindowName { get; set; }
        public int ElementId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ElementTypeName { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
