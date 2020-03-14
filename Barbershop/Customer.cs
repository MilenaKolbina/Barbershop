using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Customer
    {
        private static int cur_max_id = 0;
        private int id;
        public string name;
        public string last_name;


        public Customer(string _name, string last_name)
        {
            id = cur_max_id;
            cur_max_id++;
            this.name = _name;
            this.last_name = last_name;
        }

        public void print()
        {
            Console.WriteLine("____________________________");
            Console.WriteLine("Клиент №" + id + ":");
            Console.WriteLine(name + " " + last_name);     
            Console.WriteLine("____________________________");
        }

        public bool is_compare(Customer customer)
        {
            if (id == customer.id && name == customer.name && last_name == customer.last_name)
                return true;
            return false;
        }
    }
}
