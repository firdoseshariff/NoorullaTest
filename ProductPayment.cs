using PaymentBusinessLayer.IPayment;
using RepositoryPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBusinessLayer.OrderPay
{
    public class ProductPayment : IProductPayment
    {
      

        public Task<int> AddProductPayment(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
