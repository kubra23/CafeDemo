using CafeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDemo.Abstract
{
   public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
