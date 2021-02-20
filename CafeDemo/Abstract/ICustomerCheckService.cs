using CafeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CafeDemo.Abstract
{
   public interface ICustomerCheckService
    {
      bool CheckIfRealPerson(Customer customer);
    }
}
