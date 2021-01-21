using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri veri tabanına aşağıdaki bilgiler ile eklendi.");
            Console.WriteLine("Müşteri Id: " + customer.CustomerID);
            Console.WriteLine("Müşteri Ad Soyad: " + customer.CustomerName + " " + customer.CustomerSurname);
            Console.WriteLine("Müşteri TC Kimlik Numarası: " + customer.CustomerIdentityNumber);
            Console.WriteLine("Müşteri Telefon Numarası: " + customer.CustomerPhoneNumber);
            Console.WriteLine("Müşteri Adresi: " + customer.CustomerAddress);
            Console.WriteLine("Müşteri Bakiyesi: " + customer.CustomerBalance);
            Console.WriteLine("-----------------------------------------");
        }

        public void Delete(int customerId)
        {
            Console.WriteLine(customerId + " ID'ye sahip müşteri veritabanından silindi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerID + " ID'ye sahip müşteri veritabanından silindi");
        }

        public void GetAllCustomers(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri Id: " + customer.CustomerID);
                Console.WriteLine("Müşteri Ad Soyad: " + customer.CustomerName+ " "+customer.CustomerSurname);
                Console.WriteLine("Müşteri TC Kimlik Numarası: " + customer.CustomerIdentityNumber);
                Console.WriteLine("Müşteri Telefon Numarası: " + customer.CustomerPhoneNumber);
                Console.WriteLine("Müşteri Adresi: " + customer.CustomerAddress);
                Console.WriteLine("Müşteri Bakiyesi: " + customer.CustomerBalance);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
