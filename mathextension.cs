using System;

namespace extensionmethods
{
    public static class newOperations
    {
        public static int subtraction(this mathematics myobj, int firstnumber, int secondnumber)
        {
            return firstnumber - secondnumber;
        }
    }
}