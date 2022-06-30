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

        }
    }
}
