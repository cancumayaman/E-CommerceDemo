using Business.CrossCuttingConcerns.Interception;
using Castle.DynamicProxy;
using FluentValidation;

using System;
using System.Linq;

 namespace Business.CrossCuttingConcerns.Validation
 {
    public class ValidationAspect :InterceptionAttribute
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }
        public override  void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                var context = new ValidationContext<object>(entity);

                var result = validator.Validate(context);
                if (!result.IsValid)
                {
                    throw new ValidationException(result.Errors);
                }
            }
        }
    }
 }







