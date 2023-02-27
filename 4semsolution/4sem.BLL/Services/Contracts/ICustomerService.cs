using _4sem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem.BLL.Services.Contracts
{
    public interface ICustomerService
    {
        void ValidateAndSaveCustomer(Customer customer);
        Customer ReadCustomer(int id);
    }
}
