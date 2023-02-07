﻿

namespace SOM.Core.Model
{
    public class WindowModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int? SubElement { get; set; }
        public List<WindowElementModel>? WindowElement { get; set; }
    }
}
