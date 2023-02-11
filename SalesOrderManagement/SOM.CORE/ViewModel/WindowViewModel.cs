
namespace SOM.Core.ViewModel
{
    public class WindowViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int? SubElement { get; set; }
        public List<WindowElementViewModel>? WindowElement { get; set; }
    }
}
