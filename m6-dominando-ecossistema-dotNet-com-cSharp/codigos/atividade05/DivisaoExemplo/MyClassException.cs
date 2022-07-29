using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DivisaoExemplo
{
    [Serializable]

    public class MyClassException : Exception
    {
        public MyClassException()
        {
        }

        public MyClassException(string? message) : base(message)
        {
        }

        public MyClassException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MyClassException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public string? MyProperty { get; set; }
    }
}