using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDAL
{
    public class InventoryRepo
    {
        public IEnumerable<Inventory> GetAll() {
            using (var context = new AutoLotEntities()) {
                return context.Inventories.ToList<Inventory>();
            }
        }
    }
}
