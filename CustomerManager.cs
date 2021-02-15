using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer is add");
            Console.WriteLine("-----Customer İnformation----------");
            Console.WriteLine("name:" + customer.name + " job : " + customer.job + " salary : " + customer.salary);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer is Delete");
            Console.WriteLine("-----Customer İnformation----------");
            Console.WriteLine("name:" + customer.name + " job : " + customer.job + " salary : " + customer.salary);
        }
        public void PrintCustomer(Customer customer)
        {
            Console.WriteLine("Customer is Print");
            Console.WriteLine("-----Customer İnformation----------");
            Console.WriteLine("name:" + customer.name + " job : " + customer.job + " salary : " + customer.salary);
        }


    }

}
