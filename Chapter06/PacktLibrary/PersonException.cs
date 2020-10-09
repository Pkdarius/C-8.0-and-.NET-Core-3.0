using System;
using static System.Console;

namespace PacktLibrary
{
    public class PersonException: Exception
    {
        public PersonException(): base()
        {

        }

        public PersonException(string message): base(message)
        {

        }

        public PersonException(string message, Exception innerException): base(message, innerException)
        {
            
        }
    }
}