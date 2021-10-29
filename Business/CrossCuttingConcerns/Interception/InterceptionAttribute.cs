using Castle.DynamicProxy;
using System;

 namespace Business.CrossCuttingConcerns.Interception
 {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class InterceptionAttribute : Attribute, IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {
            bool isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
        public virtual void OnBefore(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, Exception ex) { }
        public virtual void OnSuccess(IInvocation invocation) { }
        public virtual void OnAfter(IInvocation invocation) { }
    }
 } 




