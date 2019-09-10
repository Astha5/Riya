using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GArbageCollection
{

    public class Customer:IDisposable
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        private FileStream fs;

        //constructor
        public Customer()
        {
            fs = new FileStream(@"c:\Capg\something.txt",FileMode.Create,FileAccess.Write);
            byte[] barray = System.Text.Encoding.ASCII.GetBytes("Hello");
            fs.Write(barray, 0, barray.Length);
        }
        //destructor
        //~Customer()
        //{
        //    fs.Close();
        //    Console.WriteLine("File Closed");
        //}
        public void Dispose()
        {
            fs.Close();
            Console.WriteLine("File Closed");
        }
    }
    class Program
    {
        static void Main()
        {
            //Create obj-->Constructor-->File opened
            using (Customer customer = new Customer())
            {
                //we want to close and delete file
            }
        }
    }
}

