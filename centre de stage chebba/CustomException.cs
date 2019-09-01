using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centre_de_stage_chebba
{
    class CustomException : ApplicationException
    {

        public enum ExceptionType
        {
            Info, Warn, Error
        }
        public ExceptionType Type
        {
            get;
            set;                                        
        }
        
        public string DetailMessage
        {
            get;
            set;
        }

        public CustomException (string message) : base(message)
        {
            Type = ExceptionType.Warn;
        }

        public CustomException(string message, ExceptionType type, string detailMessage)
            : base(message)
        {
            Type = type;
            DetailMessage = detailMessage;
        }
    
}
}
