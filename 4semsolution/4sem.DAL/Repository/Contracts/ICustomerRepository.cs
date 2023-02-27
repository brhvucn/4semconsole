using _4sem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem.DAL.Repository.Contracts
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        void SaveCustomer(Customer customer);
    }
}
