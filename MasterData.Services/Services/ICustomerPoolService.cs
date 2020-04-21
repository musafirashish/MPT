using MasterData.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterData.Services.Services
{
    public interface ICustomerPoolService
    {
        IList<CustomerPool> GetAllCustomerPool();
        CustomerPool GetCustomerPoolById(int customerPoolId);
        void Add(CustomerPool customerPool);
        void Update(CustomerPool customerPool);
        void Delete(CustomerPool customerPool);
    }
}
