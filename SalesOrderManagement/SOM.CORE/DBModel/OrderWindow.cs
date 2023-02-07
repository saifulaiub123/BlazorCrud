using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Core.DBModel
{
    public class OrderWindow : BaseEntity<int>
    {
        public int OrderId { get; set; }
        public int WindowId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
