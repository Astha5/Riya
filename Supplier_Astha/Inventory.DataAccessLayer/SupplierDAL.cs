using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Entities;


namespace Inventory.DataAccessLayer
{
    public class SupplierDAL
    {
        //this is a service class....adding of entries
        //add list if validated
        public static List<Supplier> SupplierList = new List<Supplier>();

        public bool AddSupplierDAL(Supplier newSupplier)
        {
            bool SupplierAdded = false;
            try
            {
                SupplierList.Add(newSupplier);
                SupplierAdded = true;
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return SupplierAdded;

        }

        public List<Supplier> GetAllSupplierDAL()
        {
            return SupplierList;
        }

        public Supplier SearchSupplierDAL(int searchSupplierId)
        {
            Supplier searchSupplier = null;
            try
            {
                foreach(Supplier item in SupplierList)
                {
                    if ((item.SupplierId) .Equals (searchSupplierId))
                    {
                        searchSupplier = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchSupplier;
        }

        public List<Supplier> GetSuppliersByNameDAL(string SupplierName)
        {
            List<Supplier> searchSupplier = new List<Supplier>();
            try
            {
                foreach (Supplier item in SupplierList)
                {
                    if (item.SupplierName == SupplierName)
                    {
                        searchSupplier.Add(item);
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return searchSupplier;
        }

        public bool UpdateSupplierDAL(Supplier updateSupplier)
        {
            bool SupplierUpdated = false;
            try
            {
                for (int i = 0; i < SupplierList.Count; i++)
                {
                    if (SupplierList[i].SupplierId == updateSupplier.SupplierId)
                    {
                        updateSupplier.SupplierName = SupplierList[i].SupplierName;
                        updateSupplier.SupplierPhone = SupplierList[i].SupplierPhone;
                        updateSupplier.SupplierEmail = SupplierList[i].SupplierEmail;
                        
                        SupplierUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new Exception(ex.Message);
            }
            return SupplierUpdated;

        }

        public bool DeleteSupplierDAL(int deleteSupplierId)
        {
            bool SupplierDeleted = false;
            try
            {
                Supplier deleteSupplier = null;
                foreach (Supplier item in SupplierList)
                {
                    if ((item.SupplierId) .Equals (deleteSupplierId))
                    {
                        deleteSupplier = item;
                    }
                }

                if (deleteSupplier != null)
                {
                    SupplierList.Remove(deleteSupplier);
                    SupplierDeleted = true;
                }
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
            return SupplierDeleted;

        }
       
    }
}
