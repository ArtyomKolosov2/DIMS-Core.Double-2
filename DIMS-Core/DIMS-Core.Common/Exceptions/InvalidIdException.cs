using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMS_Core.Common.Exceptions
{
    
    public class InvalidIdException : BaseException
    {
        public int Id { get; set; }
        public string MethodName { get; set; }

        public InvalidIdException() : base()
        {

        }

        public InvalidIdException(string message) : base(message)
        {

        }

        public InvalidIdException(string message, string methodName, int id) : base(message)
        {
            MethodName = methodName;
            Id = id;
        }

    }
}
