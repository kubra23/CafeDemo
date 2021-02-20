using CafeDemo.Abstract;
using CafeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDemo.Concrete
{
    public class StarbuksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public StarbuksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else 
            {

                throw new Exception("Not a valid person");
            }
        }


    }
}
