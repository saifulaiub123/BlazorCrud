using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Core.Model
{
    public class ElementModel
    {
        public int? Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int ElementTypeId { get; set; }
    }
}
