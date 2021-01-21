using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // müşterileri liste olarak yaratma
            Customer[] customers = new Customer[]
            {
                new Customer{
                CustomerID=1
                ,CustomerAddress="İstanbul"
                ,CustomerBalance=5000.00
                ,CustomerIdentityNumber="11111111111"
                ,CustomerName="Ali"
                ,CustomerSurname="Veli"
                ,CustomerPhoneNumber="05555555555"},
                new Customer{
                CustomerID=2
                ,CustomerAddress="Ankara"
                ,CustomerBalance=6000.00
                ,CustomerIdentityNumber="22222222222"
                ,CustomerName="Nazlı"
                ,CustomerSurname="Nazlı"
                ,CustomerPhoneNumber="03333333333"},
                new Customer{
                CustomerID=3
                ,CustomerAddress="İzmir"
                ,CustomerBalance=10000.00
                ,CustomerIdentityNumber="33333333333"
                ,CustomerName="Ahmet"
                ,CustomerSurname="Güçlü"
                ,CustomerPhoneNumber="02122121212"},
            };
            CustomerManager customerManager = new CustomerManager();
            //Müşterileri liste olarak ekleme.
            foreach (var customer in customers)
            {
                customerManager.Add(customer);
            }
            Console.WriteLine("Toplam 3 müşteri eklendi.");
            Console.WriteLine("********************************");
            //Tek müşteri id si ile silme
            customerManager.Delete(2);
            //müşteri nesnesiyle müşteriyi silme
            foreach (var customer in customers)
            {
                customerManager.Delete(customer);
            }
            //Bütün müşterileri çekme
            customerManager.GetAllCustomers(customers);
        }
    }
}
