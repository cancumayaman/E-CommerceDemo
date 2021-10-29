using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

 namespace Business.CrossCuttingConcerns.Interception
 {
    public class AspectSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<InterceptionAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<InterceptionAttribute>(true);
            classAttributes.AddRange(methodAttributes);

            return classAttributes.ToArray();
        }
    }
 }
