using DIMS_Core.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIMS_Core.Common.Helpers
{
    public static class RepositoriesExceptionHelper
    {
        public static void ThrowIfIdInvalid(int id, string methodName = "")
        {
            if (id == 0)
            {
                throw new InvalidIdException("Id is invalid!", methodName, id);
            }
        }

        public static void ThrowIfEntityObjectNotExist(object entityObject, string entityName, string methodName = "")
        {
            if (entityObject is null)
            {
                throw new EntityObjectNotExistsException($"Entity {entityName} doesn't exists in database!", entityName, methodName);
            }
        }
    }
}
