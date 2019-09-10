using System;
using System.Collections.Generic;
using System.Reflection;
using SampleNamespace;

namespace AssemblyExample
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
           // customer.GetCustomerNAmeUpperCase();
            //Console.WriteLine("Enter Customer NAme");
            customer.CustomerName = "Astha";
            Console.WriteLine(customer.GetCustomerNAmeUpperCase());
            customer.CustomerId = 3024;
            Console.WriteLine(customer.CustomerId);
            //Reflection:obtaining types of assembly
            Assembly assembly = Assembly.GetAssembly(typeof(Customer));
            Console.WriteLine("Full Name:" + assembly.FullName);
            Console.WriteLine("Code Base:" + assembly.CodeBase);

            Type[] classes = assembly.GetTypes();
            foreach (Type cls in classes)
            {
                Console.WriteLine(cls.Name);
                Console.WriteLine(cls.Name);
                Console.WriteLine("\n Properties:");
                foreach (PropertyInfo prop in cls.GetProperties())
                {
                    Console.WriteLine(prop);
                }
                Console.WriteLine("\n Methods:");
                foreach (MethodInfo meth in cls.GetMethods())
                {
                    Console.WriteLine(meth);
                }
                Console.WriteLine("\n Fields:");
                foreach (FieldInfo fie in cls.GetFields())
                {
                    Console.WriteLine(fie);
                }
                Console.WriteLine("\n Attributes:");
                foreach (Attribute atr in cls.GetCustomAttributes())
                {
                    Console.WriteLine(atr);
                }
            }
            Console.ReadKey();
        

        }

    }
}
