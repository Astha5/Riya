using System;

using System.Text.RegularExpressions;


namespace RegExExample
{
    class Customer
    {
        private string _customerName;
        private string _email;
        //name should be alphbets only(upper/lower/space)
        public string CustomerName
        {
            set
            {
                Regex regex=new Regex("^[a-zA-Z ]*$");//;lower upper space *=many allowed, $=ending
               bool b= regex.IsMatch(value);
               
                if(b==true)
                {
                    _customerName = value;

                }
                else
                {
                    throw new Exception("Customer Name must contain alphabets only");
                }
            }
            get
            {
                return _customerName;
            }
        }
        public string Email
        {
            set
            {
                Regex regex = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");//regex foe email
                bool b = regex.IsMatch(value);

                if (b == true)
                {
                    _email = value;

                }
                else
                {
                    throw new Exception("Email format incorrect");
                }
            }
            get
            {
                return _email;
            }

        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                Customer customer = new Customer();
                Console.WriteLine("Write Customer Name");
                customer.CustomerName = Console.ReadLine();
               
                Console.WriteLine("Write Email");
                customer.Email = Console.ReadLine();

                Console.WriteLine("Customer Name= " + customer.CustomerName);
                Console.WriteLine("Customer Email= " + customer.Email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
