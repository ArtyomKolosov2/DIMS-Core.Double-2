using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMS_Core.Common.Exceptions
{
    public class EntityObjectNotExistsException : BaseException
    {
        public string ObjectName { get; set; }
        public string MethodName { get; set; }

        public EntityObjectNotExistsException() : base()
        { 
        }

        public EntityObjectNotExistsException(string message) : base(message)
        {

        }

        public EntityObjectNotExistsException(string message, string objectName, string methodName) : base(message)
        {
            ObjectName = objectName;
            MethodName = methodName;
        }
    }
}
