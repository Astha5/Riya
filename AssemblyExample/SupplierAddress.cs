using System;
using System.Collections.Generic;
using System.Linq;
using Capgemini.Inventory.Helpers.ValidationAttributes;

namespace Capgemini.Inventory.Entities
{
    /// <summary>
    /// Interface for Supplier Entity
    /// </summary>
    public interface ISupplierAddress
    {

        Guid SupplierAddressID { get; set; }
        string SupplierAddressLine1 { get; set; }
        string SupplierAddressLine2 { get; set; }
        string SupplierCity { get; set; }
        string SupplierState { get; set; }
        string SupplierPincode { get; set; }



    }

    /// <summary>
    /// Represents Supplier
    /// </summary>
    public class SupplierAddress : ISupplierAddress
    {
        /* Auto-Implemented Properties */
        [Required("Supplier Address ID can't be blank.")]
        public Guid SupplierAddressID { get; set; }


        [Required("Supplier AddressLine1 can't be blank.")]
        [RegExp(@"^(\w{2,40})$", "Supplier AddressLine1 should contain only 2 to 40 characters.")]
        public string SupplierAddressLine1 { get; set; }

        [Required("Supplier AddressLine2 can't be blank.")]
        [RegExp(@"^(\w{2,40})$", "Supplier AddressLine2 should contain only 2 to 40 characters.")]
        public string SupplierAddressLine2 { get; set; }

        [RegExp(@"^[1-9]\d{5}$", "Pincode  should contain 6 digits")]
        public string SupplierPincode { get; set; }

        [Required("Supplier City can't be blank.")]
        [RegExp(@"^(\w{2,40})$", "Supplier AddressLine2 should contain only 2 to 40 characters.")]
        public string SupplierCity { get; set; }

        [Required("Supplier State can't be blank.")]
        [RegExp(@"^(\w{2,40})$", "Supplier AddressLine2 should contain only 2 to 40 characters.")]
        public string SupplierState { get; set; }


        /* Constructor */
        public SupplierAddress()
        {
            SupplierAddressID = default(Guid);
            SupplierAddressLine1 = null;
            SupplierAddressLine2 = null;
            SupplierCity = null;
            SupplierState = null;
            SupplierPincode = null;
        }
    }
}