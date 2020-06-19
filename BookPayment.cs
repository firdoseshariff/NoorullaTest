using PaymentBusinessLayer.IPayment;
using RepositoryPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBusinessLayer.Payment
{
    public class BookPayment : IBookPayment
    {
      

        public Task<int> AddDuplicateSlip(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
