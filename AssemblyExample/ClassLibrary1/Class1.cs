using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace SampleNamespace
{
    public class SampleAttribute : Attribute
    {
        public SampleAttribute()

        {
            Console.WriteLine("Constructer is called");
        }

    }
    [Sample]
    [Serializable]
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string GetCustomerNAmeUpperCase()
        {
            Type type = typeof(Customer);
            if (type.GetCustomAttribute(typeof(SampleAttribute)) != null)
                return CustomerName.ToUpper();
            else
                return CustomerName;

        }
        public int XYZ()
        {
            return 4;
        }
    }
}
