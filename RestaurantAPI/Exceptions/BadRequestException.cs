using System;
using System.Threading;

namespace RestaurantAPI.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
            
        }
    }
}
