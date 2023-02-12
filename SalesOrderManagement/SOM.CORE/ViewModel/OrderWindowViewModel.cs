using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Core.ViewModel
{
    public class OrderWindowViewModel
    {
        public OrderWindowViewModel() 
        {
        }

        public int? Id { get; set; }
        public int OrderId { get; set; }
        public int WindowId { get; set; }
        public string WindowName { get; set; }
        public string WindowQuantity { get; set; }
    }
}
