using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrbanStore.Domain.Validations
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error){}
        public static void ExceptionHandler(bool hasError, string error){
            if(hasError){
                throw new DomainExceptionValidation(error);
            }
        }
    }
}