using _4sem.DAL.Repository.Contracts;
using _4sem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(int id)
        {
            //just for test, later it will need to get it from database
            return null;
        }

        public void SaveCustomer(Customer customer)
        {
            //save to database
            Console.WriteLine("Im saving to the database");
        }
    }
}
