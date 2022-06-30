using System;

namespace Solid_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISP
            Person Customer1 = new Person("Tomasz","Gancarz","Polanowicka","TG@gmail.com",123123123, "Wrocław");
            //LSP
            BasicDataSHop description = new Invoice();
            Console.WriteLine(description.Description());
            description = new Complain();
            Console.WriteLine(description.Description()+"   Customer name: "+description.GetPersonName(Customer1));
            //OCP
            GrossSalaryToNetForWorker worker1 = new GrossSalaryToNetForWorker();
            OrderVat product = new OrderVat();
            Console.WriteLine("worker1 get:"+worker1.Percent(3200)+" zl net\n"+"product netto+ vat:"+product.Percent(40)+" zl");
            //DIP
            IDelivery delivery = new Post();
            CompleteOrder completeOrder = new CompleteOrder(delivery);
            completeOrder.TakeDelivery();
            delivery = new GLS();
            completeOrder = new CompleteOrder(delivery);
            completeOrder.TakeDelivery();
          
        }
    }
}
