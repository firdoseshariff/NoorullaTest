using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPayment;

namespace PaymentBusinessLayer.IPayment
{
 public   interface ILearning
    {
        Task<int> AddLearning(Vedio vedio);
    }
}
