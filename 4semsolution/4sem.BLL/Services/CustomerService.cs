using _4sem.BLL.Services.Contracts;
using _4sem.DAL.Repository.Contracts;
using _4sem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4sem.BLL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository) 
        { 
            this.customerRepository = customerRepository;
        }

        public Customer ReadCustomer(int id)
        {
            return this.customerRepository.GetCustomer(id);
        }

        public void ValidateAndSaveCustomer(Customer customer)
        {
            //validate customer
            if (customer == null) { throw new ArgumentNullException(); }            
            //save the customer if it validates
            this.customerRepository.SaveCustomer(customer);
        }
    }
}
