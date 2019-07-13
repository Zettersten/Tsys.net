using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Tsys.net.Models.Exceptions
{
    [Serializable]
    public class TsysException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public TsysException()
        {
        }

        public TsysException(string code, string text)
            : base($"{code}: {text}")
        {
        }

        public TsysException(string message)
            : base(message)
        {
        }

        public TsysException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected TsysException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ResourceReferenceProperty = info.GetString(nameof(ResourceReferenceProperty));
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            info.AddValue(nameof(ResourceReferenceProperty), ResourceReferenceProperty);

            base.GetObjectData(info, context);
        }
    }
}