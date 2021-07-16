using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemoOperations
{
    public class RegexCustomException:Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,NULL_MESSAGE,INVALID_EMAIL,INVALID_PASSWORD
        }
        ExceptionType exceptiontype;
        public RegexCustomException(ExceptionType exception, string message) : base(message)
        {
            this.exceptiontype = exception;
        }
    }
}
