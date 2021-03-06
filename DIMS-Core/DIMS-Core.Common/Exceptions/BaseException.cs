using System;

namespace DIMS_Core.Common.Exceptions
{
    /// <summary>
    ///     You can use this class for your custom exceptions
    /// </summary>
    public abstract class BaseException : Exception
    {
        protected BaseException()
        {
        }
        protected BaseException(string message) : base(message)
        {
        }
    }
}