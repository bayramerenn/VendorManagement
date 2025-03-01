﻿using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Core.Aspect.Autofac.Transaction
{
    public class TransactionScopeAspect:MethodInterception
    {
        public override void InterceptAsynchronous<TResult>(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch (Exception e)
                {
                    transactionScope.Dispose();
                    throw new Exception(e.Message);
                }
            }
        }
    }
}
