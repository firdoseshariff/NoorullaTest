using PaymentBusinessLayer.IPayment;
using RepositoryPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentBusinessLayer.Payment
{
    public class AddOrUpgradeUser : IAddOrUpgradeUser
    {
        private PaymentGateWayEntities crud;
        public AddOrUpgradeUser(PaymentGateWayEntities _crud)
        {
            crud = _crud;
        }
        public async Task<int> AddUser(RegisterUser registerUser)
        {try
            {
                //AddLogic


                return registerUser.RegisterId;
            
             }
            catch(Exception ex)
            {
                throw ex;
            }
}

      

      public async  Task<object> UpGradeUser()
        {
            throw new NotImplementedException();
        }
    }
}
