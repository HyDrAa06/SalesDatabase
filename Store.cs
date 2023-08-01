using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Database.Database
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public IList<Sale> Sales { get; set; }
    }
}
