using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Service
    {
        private int id;
        public string name;
        public int price;
        private static int cur_max_id = 0;


        public Service(string name, int price)
        {
            this.name = name;
            this.price = price;
            id = cur_max_id;
            cur_max_id++;
        }
        public void print()
        {
            Console.WriteLine("____________________________");
            Console.WriteLine("Услуга №" + id + ":");
            Console.WriteLine(" Название - " + name);
            Console.WriteLine(" Цена - " + price);
            Console.WriteLine("____________________________");
        }

        public bool is_compare(Service service)
        {
            if (id == service.id && name == service.name && price == service.price)
                return true;
            return false;
        }
    }
}
