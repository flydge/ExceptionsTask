using System;
using System.Runtime.Serialization;

namespace ExceptionsTask
{
    [Serializable]
    public class CustomException: Exception
    {
        private string _wrongName;
        
        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }
      
        public CustomException(string wrongName,string message) : base(wrongName + message)
        {
            _wrongName = wrongName;
        }

        public CustomException(string wrongName,string message, Exception innerException) : base(message, innerException)
        {
            _wrongName = wrongName;
        }

        protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            WrongName = info.GetValue("WrongName", typeof(string)).ToString();
        }

        
        
        private string WrongName
        {
            get => _wrongName;
            set => _wrongName = value;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("WrongName", WrongName);
        }
        
        

        
    }
}