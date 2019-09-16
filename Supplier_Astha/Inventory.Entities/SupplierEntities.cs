using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Entities
{
    
        public class Supplier
        {

        private string _supplierName;
        public string SupplierName
        {
            get { return _supplierName; }
            set { _supplierName = value; }
        }

        private string _supplierId;
        public string SupplierId
        {
            get { return _supplierId; }
            set { _supplierId = value; }
        }

        private string _supplierPhone;
        public string SupplierPhone
        {
            get { return _supplierPhone; }
            set { _supplierPhone = value; }
        }

        private string _supplierEmail;
        public string SupplierEmail
        {
            get { return _supplierEmail; }
            set { _supplierEmail = value; }
        }
        public Supplier()
        {
            _supplierName = null;
            _supplierId = null;
            _supplierEmail = null;
            _supplierPhone = null;

        }


        //validate normally
    }
    


}
