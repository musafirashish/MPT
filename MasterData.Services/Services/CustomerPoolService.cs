using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MasterData.Services.Model;
using MasterData.Services.Repository;

namespace MasterData.Services.Services
{
    public class CustomerPoolService : ICustomerPoolService
    {
        private readonly IMPTRepository _mptRepository;

        public CustomerPoolService(IMPTRepository MPTRepository)
        {
            _mptRepository = MPTRepository;

        }
        public IList<CustomerPool> GetAllCustomerPool()
        {
            return _mptRepository.GetAll<CustomerPool>().ToList();
        }
        public CustomerPool GetCustomerPoolById(int customerPoolId)
        {
            return _mptRepository.Get<CustomerPool>(customerPoolId);
        }
        public void Add(CustomerPool customerPool)
        {
            _mptRepository.Add<CustomerPool>(customerPool);
        }
        public void Delete(CustomerPool customerPool)
        {
            _mptRepository.Delete<CustomerPool>(customerPool);
        }
        public void Update(CustomerPool customerPool)
        {

            _mptRepository.Update<CustomerPool>(customerPool);
        }
    }
}
