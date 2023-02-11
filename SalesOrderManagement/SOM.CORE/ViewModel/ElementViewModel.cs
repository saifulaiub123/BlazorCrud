

namespace SOM.Core.ViewModel
{
    public class ElementViewModel : ICloneable
    {
        public int? Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int ElementTypeId { get; set; }
        public string ElementTypeName { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
