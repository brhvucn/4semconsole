using _4sem.DAL.Repository.Contracts;
using _4sem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem.bll.tests.FakeObjects
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(int id)
        {
            return new Customer();
        }

        public void SaveCustomer(Customer customer)
        {
            Console.WriteLine("Im a fake customer repository and I am saving");
        }
    }
}
