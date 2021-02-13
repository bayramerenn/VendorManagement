using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple =true,Inherited =true)]
    public class MethodInterceptionBaseAttribute : Attribute, IAsyncInterceptor
    {
        public int Priority { get; set; }
        public virtual void InterceptAsynchronous(IInvocation invocation)
        {
            
        }

        public virtual void InterceptAsynchronous<TResult>(IInvocation invocation)
        {
            
        }

        public virtual void InterceptSynchronous(IInvocation invocation)
        {
            
        }
    }
}
