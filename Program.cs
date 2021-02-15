using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 1;
            c1.name = "enser";
            c1.age = 22;
            c1.job = "Computer Engineer";
            c1.salary = 3000;

            Customer c2 = new Customer();
            c2.ID = 2;
            c2.name = "Uğurcan";
            c2.age = 23;
            c2.job = "Computer Engineer";
            c2.salary = 200;

            Customer c3 = new Customer();
            c3.ID = 3;
            c3.name = "Ateşçakmak";
            c3.age = 2;
            c3.job = "Computer Engineer";
            c3.salary = 4000;

            Customer[] customers = new Customer[]{ c1, c2, c3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(c1);
            Console.WriteLine("-----------------------------------------------");
            customerManager.DeleteCustomer(c2);
            Console.WriteLine("------------------------------------------------");
            customerManager.PrintCustomer(c3);
        }
    }
}
