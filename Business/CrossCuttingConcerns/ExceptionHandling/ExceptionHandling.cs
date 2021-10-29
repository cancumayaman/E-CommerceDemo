using Business.CrossCuttingConcerns.Interception;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.ExceptionHandling
{
   public class ExceptionHandling:InterceptionAttribute
    {
        public override void OnException(IInvocation invocation,Exception ex)
        {
                throw new Exception(ex.Message);          
        }
    }
}

