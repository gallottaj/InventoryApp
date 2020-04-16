using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class InventoryItem
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManufacturerID { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
    }
}
