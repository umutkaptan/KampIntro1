using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
